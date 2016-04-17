
namespace Carrick.ClientData.DataProviders
{

    using Carrick.DataModel;
    using Carrick.ClientData.Web;
    using SQLite.Net;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using BusinessLogic.Interfaces;
    using System.Linq;
    using DataProviders;

    public abstract class DataProviderBase<T,Z> : IDataProviderInterface<T>, IClientDataProvider where T : ITableBase where Z : TableBase, new()

    {

        private LocalDataProvider<Z> _localStore;

        protected ModelDataProvider modelDataProvider;
        protected WebAPIHelper<T> helper;
        
        protected ResolveConflictDelegate<T> resolver;

        internal DataProviderBase(ModelDataProvider modelDataProvider)
        {
            this.modelDataProvider = modelDataProvider;
            _localStore = new LocalDataProvider<Z>();
            _localStore.modelDataProvider = modelDataProvider;
            _localStore.Initialise();
        }
   


        // http://havrl.blogspot.com.au/2013/08/synchronization-algorithm-for.html

        //1.Initialize the list of tables required to sync
        //******* Download server changes **********/
        //For each sync table: 2.Get the latest timestamp, e.g. using sqlite “select ifnull(ts, 0) from Table order by ts desc limit 1”
        //
        //3.Call the relevant RESTful service method to get server changes as collection for the table based on the provided latest timestamp
        //* Insert or update the received changes into local storage 

        //*/ 4.Iterate through each record in the server changes collection
        //◦Check if the server record with the same id already exists in the local storage
        //◦If so then check if the existing local record is dirty
        //◦If so then call some conflict resolution function
        //◦Reset dirty flag
        //◦Else replace the local record with the server record and reset the dirty flag
        //◦If the local storage doesn’t have the server record, then create it
        //******* Upload client changes **********/
        //For each sync table:
        //5.Get the list of local storage changes for inserts on the server
        //6.Iterate through each record in the local changes for inserts
        //◦Insert the record on the server(using POST)
        //◦Get the timestamp for the inserted record from the response
        //◦Update the record in the local storage with new timestamp
        //◦Reset the dirty flag
        //7.Get the list of local storage changes for updates on the server
        //8.Iterate through each record in the local changes for updates
        //◦Update the record on the server(using PUT)
        //◦Get the updated timestamp for the updated record from the response
        //◦Update the record in the local storage with new timestamp
        //◦Reset the dirty flag
        //******* Post sync operation ************/
        //For each sync table:
        //9.Delete records where Deleted = true and Dirty = false
        public void Sync()
        {
            // Download any changes from the server
            T[] i = helper.GetSync(_localStore.GetLatestUpdateDatetime());
            foreach (T y in i)
            {
                InsertUpdateServerChange(y, resolver);
            }

            //Make a local copy
            //List<Z> itms = new List<Z>();
            //foreach (Z s in Items.Values)
            //{
            //    itms.Add(s);
            //}

            // Upload any new items
            foreach (Z s in _localStore.GetAllItems())
            {
                if (s.RowLastUpdated == null)
                {
                    DataStoredResponse resp = helper.Insert(Convert(s));
                    s.RowLastUpdated = resp.RowLastUpdated;
                    _localStore.UpdateLocalItem(s);
                }

                if (s.IsDirty.HasValue)
                    if( s.IsDirty.Value)
                    {
                        DataStoredResponse resp = helper.Update(s.Id, Convert(s));
                        s.RowLastUpdated = resp.RowLastUpdated;
                        s.IsDirty = false;
                        _localStore.UpdateLocalItem(s);
                    }
            }


        }

        public static ResolveConflictOption ResolveConflictFavourClient(T clientitem, T serveritem)
        {
            return ResolveConflictOption.FavourClient;
        }

        public static ResolveConflictOption ResolveConflictFavourServer(T clientitem, T serveritem)
        {
            return ResolveConflictOption.FavourServer;
        }

        public IEnumerable<T> GetAllItems()
        {
            return Convert(_localStore.GetAllItems());
        }

        protected internal void  CreateWebAPIHelper( String relativelocation)
        {
            helper = new WebAPIHelper<T>(modelDataProvider.client, "api/" + relativelocation);
        }


        public T InsertItem(T itm)
        {
            return Convert(_localStore.InsertItem(Convert(itm)));
        }

        public abstract T Convert(Z z);

        public abstract Z Convert(T z);

        public IEnumerable<T> Convert(IEnumerable<Z> itms)
        {
            IList <T> retval = new List<T>();
            foreach (Z itm in itms)
            {
                retval.Add(Convert(itm));
            }
            return retval;
        }


        internal protected void InsertUpdateServerChange(T serveritem, ResolveConflictDelegate<T> resolveconflict)
        {
            //Look for a local item
            Z localitem = _localStore.GetItem(serveritem.PrimaryKey());

            // Insert into the local store if a local item cannot be found
            if (localitem == null)
                InsertItem(serveritem);

            else if (localitem.RowLastUpdated != serveritem.RowLastUpdated)
            {
                if (localitem.IsDirty.HasValue)
                    if (localitem.IsDirty.Value)
                    {
                    ResolveConflictOption r = resolveconflict.Invoke(Convert(localitem), serveritem);
                    if (r == ResolveConflictOption.FavourClient)
                    {
                        // Push update back to the server
                        DataStoredResponse resp = helper.Update(localitem.Id, Convert(localitem));

                        localitem.RowLastUpdated = resp.RowLastUpdated;
                        modelDataProvider.GetLocalConnection().Update(localitem);
                    }
                    else if (r == ResolveConflictOption.FavourServer)
                    {
                        // Accept the server changes
                        OverWriteWithServerVersion(localitem, Convert(serveritem));
                    }
                    //Conflict
                    // Update the local item with the server item
                }
                else
                {
                    //Overwrite with server version no conflict
                    OverWriteWithServerVersion(localitem, Convert(serveritem));
                }
            }
        }

        internal protected void OverWriteWithServerVersion(Z clientitem, Z serveritem)
        {
            //Overwrite with server version no conflict
            serveritem.LocalId = clientitem.LocalId;
            serveritem.IsDirty = false;
            _localStore.UpdateLocalItem(serveritem);
        }


        public Type GetDataType()
        {
            return typeof(T);
        }


        public T CreateItem()
        {
            return Convert(new Z());
        }

        public T ModifyItem(T item)
        {
            return Convert(_localStore.ModifyItem(Convert(item)));
        }
   

        public T DeleteItem(T item)
        {
            return Convert(_localStore.DeleteItem(Convert(item)));
        }

        public T GetItem(IRelationshipKey key)
        {
            return Convert(_localStore.GetItem(key));
        }

        public IEnumerable<T> GetActiveItems()
        {
            return Convert(_localStore.GetActiveItems());
        }

        public void Initialise()
        {
            _localStore.Initialise();
        }

        public void LoadLocalData()
        {
            _localStore.LoadLocalData();
        }

        public IRelationshipKey CreateRelationshipKey()
        {
            return new RelationshipKey();
        }

        public T DeleteItem(IRelationshipKey key)
        {
            Convert(_localStore.DeleteItem(Convert(GetItem(key))));
            return GetItem(key);
        }

        public virtual Func<T, object> defaultOrder
        {
            get
            {
                return (T t) => t.Id;
            }
        }

    }
}
