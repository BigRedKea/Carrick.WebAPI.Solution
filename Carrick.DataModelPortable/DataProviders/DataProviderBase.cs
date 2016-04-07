
namespace ScoutDataModelPortable.DataProviders
{
    
    using Carrick.DataModel;
    using ScoutDataModelPortable.Web;
    using SQLite.Net;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    //: IDataProviderInterface<T> where T : TableBase

    public abstract class DataProviderBase<T> :IClientDataProvider  where T: TableBase, new()

    {
        protected ModelDataProvider modelDataProvider;
        protected WebAPIHelper<T> helper;
        protected Dictionary<Int32, T> Items = new Dictionary<Int32, T>();
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

        private T GetItem(Int32 id)
        {
            T s;
            Items.TryGetValue(id, out s);
            return s;
        }

        public Dictionary <Int32,T>.ValueCollection  GetItems()
        {
            return Items.Values;
        }

        protected internal void  CreateWebAPIHelper( String relativelocation)
        {
            helper = new WebAPIHelper<T>(modelDataProvider.client, relativelocation);
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

        private void InsertItem(T sr)
        {
            modelDataProvider.GetLocalConnection().Insert(sr);
            Items.Add(sr.LocalId, sr);
        }

        protected internal void UpdateLocalItem(T sr)
        {
            modelDataProvider.GetLocalConnection().Update(sr);
            Items.Remove(sr.LocalId);
            Items.Add(sr.LocalId , sr);
        }

        public void LoadLocalData()
        {
            Items.Clear();
            CreateTable(); // If it doesn't exist

            foreach (T s in GetTable())
            {
                SQLiteNetExtensions.Extensions.ReadOperations.GetChildren(modelDataProvider.GetLocalConnection(), s);
                Items.Add(s.LocalId, s);
            }
        }


        private T GetItem(Guid? uniqueId)
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

        public void ModifyItem(T sr)
        {
            sr.IsDirty = true;
            UpdateLocalItem(sr);
        }

        public void DeleteItem(T sr)
        {
            sr.IsDeleted = true;
            sr.IsDirty = true;
            UpdateLocalItem(sr);
        }

        protected internal TableQuery<T> GetTable()
        {
            return modelDataProvider.GetLocalConnection().Table<T>();
        }


        public Type GetDataType()
        {
            return typeof(T);
        }



        T CreateItem()
        {
            return new T();
        }
    }
}
