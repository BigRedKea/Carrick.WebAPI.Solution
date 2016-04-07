
namespace Carrick.Data.Controllers
{
    using Carrick.DataModel;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Data.Entity;
    using Scout.BusinessLogic.Interfaces;
    using DataControllers;

    public abstract class GenericDataProvider<T>: IDataProviderInterface<T> where T : TableBase, new()
    {
        internal protected Repository Repository;
        protected DbSet<T> dataset;


        protected internal Authorisation<T> AuthorisationGet;
        protected internal Authorisation<T> AuthorisationUpdate;

        internal GenericDataProvider(Repository r, DbSet<T> dataset)
        {
            try
            {
                Repository = r;
                this.dataset = dataset;
            }
                        catch (Exception ex)
            {
                throw new Exception("Failed to Initialise GenericDataController", ex);
            }
        
        }

        private  T _GetItem(int id)
        {
            T p = dataset.Where(x => x.Id == id).FirstOrDefault();
            dataset.Where(x => x.Id == id).FirstOrDefault();
            return p;
        }

        public virtual T GetItem(int id)
        {
            T copy = new T();
            CopyData(_GetItem(id), ref copy, AuthorisationGet);
            return copy;
        }


        public virtual T GetItem(Guid RowGuid)
        {
            T p = dataset.Where(x => x.RowGuid.ToString() == RowGuid.ToString()).FirstOrDefault();
            dataset.Where(x => x.RowGuid.ToString() == RowGuid.ToString()).FirstOrDefault();
            T copy = new T();
            CopyData(p, ref copy, AuthorisationGet);
            return copy;
        }

        public virtual T GetActiveItem(int id)
        {
            T p = _GetActiveItems().Where(x =>(x.Id == id)).FirstOrDefault();
            T copy = new T();
            CopyData(p, ref copy, AuthorisationGet);
            return copy;
        }

        public virtual IEnumerable<T> GetActiveItems()
        {
            IEnumerable<T> p = _GetActiveItems();
            IEnumerable<T> copy = CopyData(p, AuthorisationGet);
            return copy;
        }


        protected IQueryable<T> _GetActiveItems()
        {
            return dataset.Where(x => (x.IsDeleted == false));
        }

        protected IQueryable<T> _GetAllItems()
        {
            return dataset;
        }

        public virtual IEnumerable<T> GetAllItems()
        {
            IEnumerable<T> p = dataset;
            IEnumerable<T> copy = CopyData(p, AuthorisationGet);
            return copy;
        }

        protected internal abstract T TransferSpecificProperties(T original, ref T destination, Authorisation<T> a);

        protected internal T CopyData(T original, ref T destination, Authorisation<T> a)
        {
            TransferSpecificProperties(original, ref destination, a);
            destination.Id = original.Id;
            destination.IsDeleted = original.IsDeleted;
            destination.RowCreated = original.RowCreated;
            destination.RowGuid = original.RowGuid;
            destination.RowLastUpdated = original.RowLastUpdated;

            return destination;
        }

        protected internal IEnumerable<T> CopyData(IEnumerable<T> original, Authorisation<T> a)
        {
            IList<T> retval = new List<T>();
            foreach (T itm in original)
            {
                T r = new T();
                CopyData(itm, ref r, a);
                retval.Add(r);
            }
            return retval;
        }

        public IEnumerable<T> GetUpdatedItems(DateTime updatetimestamp)
        {
            List<T> retval = new List<T>();
            foreach (T r in GetAllItems())
            {
                //Find rows later than

                if (r.RowLastUpdated.HasValue)
                {
                    DateTime d1 = DateTime.Parse(updatetimestamp.ToString("yyyy-MM-dd hh:mm:ss"));
                    DateTime d2 = DateTime.Parse(r.RowLastUpdated.Value.ToString("yyyy-MM-dd hh:mm:ss"));

                    if (d2.CompareTo(d1) > 0)
                    {
                        retval.Add(r);
                    }
                }
            }

            return retval;
        }

        private T GetDataStoredResponse(T r)
        {
            //T resp = new T();
            //resp.Id = r.Id;
            //resp.IsDeleted = r.IsDeleted;
            //resp.RowLastUpdated = r.RowLastUpdated;
            //resp.RowGuid = r.RowGuid;
            return r;
        }

        /*private DataStoredResponse GetDataStoredResponse(T r)
        {
            DataStoredResponse resp = new DataStoredResponse();
            resp.Id = r.Id;
            resp.IsDeleted = r.IsDeleted;
            resp.RowLastUpdated = r.RowLastUpdated;
            resp.RowGuid = r.RowGuid;
            return resp;
        }*/

        public Type GetDataType()
        {
            return typeof(T);
        }

        public T InsertItem(T item)
        {
            item.RowLastUpdated = DateTime.UtcNow;
            if (item.RowCreated == null)
                {
                item.RowCreated = DateTime.UtcNow;
                }

            T r = dataset.Add(item);
            Repository.DataModel.SaveChanges();

            return GetDataStoredResponse(r);
        }

        public T ModifyItem(T item)
        {
            T itmtoupdate = _GetItem(item.Id);
            
            CopyData(item, ref itmtoupdate, AuthorisationUpdate);

            //itmtoupdate.Id = s.Id;
            //itmtoupdate.RowGuid = s.RowGuid;
            //itmtoupdate.IsDeleted = s.IsDeleted;

            itmtoupdate.RowLastUpdated = DateTime.UtcNow;
            
            Repository.DataModel.SaveChanges();

            return itmtoupdate;
        }

        public T DeleteItem(T item)
        {
            item.IsDeleted = true;
            return ModifyItem(item);
        }

        public T CreateItem()
        {
            T item = new T();
            item.RowGuid = Guid.NewGuid();
            return item;
        }

        public T DeleteItem(int id)
        {
            T s = GetItem(id);

            s.IsDeleted = true;
            return ModifyItem(s);
        }

        public T SaveItem(T itm)
        {
            if (itm.Id > 0)
            {
                return ModifyItem(itm);
            }
            else
            {
                return InsertItem(itm);
            }
        }


    }
}

