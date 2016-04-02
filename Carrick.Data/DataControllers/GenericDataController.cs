
namespace Carrick.Data.Controllers
{
    using Carrick.Data.Model;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Data.Entity;

    public abstract class GenericDataController<T> where T : TableBase , new()
    {
        internal protected Repository Repository;
        protected DbSet<T> dataset;


        protected internal Authorisation<T> AuthorisationGet;
        protected internal Authorisation<T> AuthorisationUpdate;

        internal GenericDataController(Repository r, DbSet<T> dataset)
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

        public virtual T[] GetActiveItems()
        {
            T[] p = _GetActiveItems().ToArray<T>();
            T[] copy = CopyData(p, AuthorisationGet);
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

        public virtual T[] GetAllItems()
        {
            T[] p = dataset.ToArray<T>();
            T[] copy = CopyData(p, AuthorisationGet);
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

        protected internal T[] CopyData(T[] original, Authorisation<T> a)
        {
            List<T> retval = new List<T>();
            foreach (T itm in original)
            {
                T r = new T();
                CopyData(itm, ref r, a);
                retval.Add(r);
            }
            return retval.ToArray<T>();
        }

        public T[] GetUpdatedItems(DateTime updatetimestamp)
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

            return retval.ToArray();
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

        public T InsertItem(T s)
        {
            s.RowLastUpdated = DateTime.UtcNow;
            if (s.RowCreated == null)
                {   
                s.RowCreated = DateTime.UtcNow;
                }

            T r = dataset.Add(s);
            Repository.DataModel.SaveChanges();

            return GetDataStoredResponse(r);
        }

        public T UpdateItem(T s)
        {
            T itmtoupdate = _GetItem(s.Id);
            
            CopyData(s, ref itmtoupdate, AuthorisationUpdate);

            //itmtoupdate.Id = s.Id;
            //itmtoupdate.RowGuid = s.RowGuid;
            //itmtoupdate.IsDeleted = s.IsDeleted;

            itmtoupdate.RowLastUpdated = DateTime.UtcNow;
            
            Repository.DataModel.SaveChanges();

            return itmtoupdate;
        }

        public T DeleteItem(int id)
        {
            T s = GetItem(id);

            s.IsDeleted = true;
            return UpdateItem(s);
        }

        public T SaveItem(T itm)
        {
            if (itm.Id > 0)
            {
                return UpdateItem(itm);
            }
            else
            {
                return InsertItem(itm);
            }
        }
    }
}

