
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

    public abstract class DataProviderBase<T,Z> : IDataProviderInterface<T>, IClientDataProvider where T : ITableBase where Z : TableBase, new()

    {
        protected ModelDataProvider modelDataProvider;
        protected WebAPIHelper<T> helper;
        protected Dictionary<int, T> Items = new Dictionary<int, T>();
        protected ResolveConflictDelegate<T> resolver;

        internal DataProviderBase(ModelDataProvider modelDataProvider)
        {
            this.modelDataProvider = modelDataProvider;
        }
   
        //protected DataModel model()
        //{
        //    return modelDataProvider.model;
        //}

        public void Initialise()
        {
            modelDataProvider.GetLocalConnection().CreateTable<T>();
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
            T[] i = helper.GetSync(GetLatestUpdateDatetime());
            foreach (T y in i)
            {
                InsertUpdateServerChange(y, resolver);
            }

            //Make a local copy
            List<T> itms = new List<T>();
            foreach (T s in Items.Values)
            {
                itms.Add(s);
            }

            // Upload any new items
            foreach (T s in itms)
            {
                if (s.RowLastUpdated == null)
                {
                    DataStoredResponse resp = helper.Insert(s);
                    s.RowLastUpdated = resp.RowLastUpdated;
                    UpdateLocalItem(s);
                }

                if (s.IsDirty)
                {
                    DataStoredResponse resp = helper.Update(s.Id, s);
                    s.RowLastUpdated = resp.RowLastUpdated;
                    s.IsDirty = false;
                    UpdateLocalItem(s);
                }
            }


        }

        protected internal void DropTable()
        {
            modelDataProvider.GetLocalConnection().DropTable<T>();
        }

        protected internal void CreateTable()
        {
            modelDataProvider.GetLocalConnection().CreateTable<T>();
        }

        public static ResolveConflictOption ResolveConflictFavourClient(T clientitem, T serveritem)
        {
            return ResolveConflictOption.FavourClient;
        }

        public static ResolveConflictOption ResolveConflictFavourServer(T clientitem, T serveritem)
        {
            return ResolveConflictOption.FavourServer;
        }

        public T GetItem(int id)
        {
            T s;
            Items.TryGetValue(id, out s);
            return s;
        }


        public IEnumerable<T> GetActiveItems()
        {
            return Items.Values.Where(x => (x.IsDeleted == false));
        }

        public IEnumerable<T> GetAllItems()
        {
            return _GetAllItems();
        }

        protected IEnumerable<T> _GetAllItems()
        {
            return Items.Values;
        }

        public Dictionary <int,T>.ValueCollection  GetItems()
        {
            return Items.Values;
        }



        public T GetItem(IRelationshipKey key)
        {
            if (key.Id.HasValue)
            {
                return GetItem(key.Id.Value);
            }
            else if (key.RowGuid.HasValue)
            {
                return GetItem(key.RowGuid);
            }
            else if (key.LocalId.HasValue)
            {
                return _GetItemFromLocalId(key.LocalId.Value);
            }
            else
            {
                return default(T);
            }
        }

        private T _GetItemFromLocalId(int LocalId)
        {
            T p = Items.Values.Where(x => x.LocalId  == LocalId).FirstOrDefault();
            return p;
        }

        protected internal void  CreateWebAPIHelper( String relativelocation)
        {
            helper = new WebAPIHelper<T>(modelDataProvider.client, "api/" + relativelocation);
        }

        protected internal DateTime? GetLatestUpdateDatetime()
        {
            DateTime? lastupdatetime = null;
            foreach (T s in Items.Values)
            {
                if (s.RowLastUpdated.HasValue)
                {
                    if ((lastupdatetime == null)
                        || (DateTime.Compare(s.RowLastUpdated.Value, lastupdatetime.Value) > 0))
                    {
                        lastupdatetime = s.RowLastUpdated.Value;
                    }
                }

            }
            return lastupdatetime;
        }

        public T InsertItem(T itm)
        {
            modelDataProvider.GetLocalConnection().Insert(itm);
            Items.Add(itm.LocalId, itm);
            return itm;
        }

         internal void UpdateLocalItem(T sr)
        {
            modelDataProvider.GetLocalConnection().Update(sr);
            Items.Remove(sr.LocalId);
            Items.Add(sr.LocalId , sr);
        }

        public void LoadLocalData()
        {
            Items.Clear();
            CreateTable(); // If it doesn't exist

            foreach (Z s in GetTable())
            {
                SQLiteNetExtensions.Extensions.ReadOperations.GetChildren(modelDataProvider.GetLocalConnection(), s);
                Items.Add(s.LocalId, Convert(s));
            }
        }

        public abstract T Convert(Z z);

        public abstract Z Convert(T z);

        public T GetItem(Guid? uniqueId)
        {
            if (uniqueId.HasValue)
            { 
            foreach (T s in Items.Values)
            {
                if (s.RowGuid.ToString() == uniqueId.Value.ToString())
                {
                    return s;
                }
            }
        }
            return default(T);
        }

        internal protected void InsertUpdateServerChange(T serveritem, ResolveConflictDelegate<T> resolveconflict)
        {
            //Look for a local item
            T localitem = GetItem(serveritem.RowGuid);

            // Insert into the local store if a local item cannot be found
            if (localitem == null)
                InsertItem(serveritem);

            else if (localitem.RowLastUpdated != serveritem.RowLastUpdated)
            {
                if (localitem.IsDirty)
                {
                    ResolveConflictOption r = resolveconflict.Invoke(localitem, serveritem);
                    if (r == ResolveConflictOption.FavourClient)
                    {
                        // Push update back to the server
                        DataStoredResponse resp = helper.Update(localitem.Id, localitem);

                        localitem.RowLastUpdated = resp.RowLastUpdated;
                        modelDataProvider.GetLocalConnection().Update(localitem);
                    }
                    else if (r == ResolveConflictOption.FavourServer)
                    {
                        // Accept the server changes
                        OverWriteWithServerVersion(localitem, serveritem);
                    }
                    //Conflict
                    // Update the local item with the server item
                }
                else
                {
                    //Overwrite with server version no conflict
                    OverWriteWithServerVersion(localitem, serveritem);
                }
            }
        }

        internal protected void OverWriteWithServerVersion(T clientitem, T serveritem)
        {
            //Overwrite with server version no conflict
            serveritem.LocalId = clientitem.LocalId;
            serveritem.IsDirty = false;
            UpdateLocalItem(serveritem);
        }

        public T ModifyItem(T itm)
        {
            itm.IsDirty = true;
            UpdateLocalItem(itm);
            return itm;
        }

        public T DeleteItem(T itm)
        {
            itm.IsDeleted = true;
            itm.IsDirty = true;
            UpdateLocalItem(itm);
            return itm;
        }

        protected internal TableQuery<Z> GetTable()
        {
            return modelDataProvider.GetLocalConnection().Table<Z>();
        }


        public Type GetDataType()
        {
            return typeof(T);
        }


        public T CreateItem()
        {
            return Convert(new Z());
        }
    }
}
