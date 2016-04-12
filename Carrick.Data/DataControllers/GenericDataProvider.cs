
namespace Carrick.ServerData.Controllers
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Data.Entity;

    using Carrick.Server.DataModel;
    using Carrick.BusinessLogic.Interfaces;
    using System.Linq.Expressions;

    public abstract class GenericDataProvider<T, Z> : IDataProviderInterface<T> where T : ITableBase where Z : TableBase, new() 
    {
        internal protected Repository Repository;
        protected DbSet<Z> dataset;


        protected internal Authorisation<T> AuthorisationGet;
        protected internal Authorisation<T> AuthorisationUpdate;

        internal GenericDataProvider(Repository r, DbSet<Z> dataset)
        {
            try
            {
                Repository = r;
                this.dataset = dataset;
                defaultOrder = (Z t) => t.Id;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to Initialise GenericDataController", ex);
            }

        }

        public abstract T Convert(Z z);

        public abstract Z Convert(T z);


        private Z _GetItem(int id)
        {
            Z p = dataset.Where(x => x.Id == id).FirstOrDefault();
            return p;
        }

        private Z _GetItemFromLocalId(int LocalId)
        {
            Z p = dataset.Where(x => x.LocalId == LocalId).FirstOrDefault();
            return p;
        }

        private Z _GetItem(Guid? RowGuid)
        {
            Z p = dataset.Where(x => x.RowGuid.ToString() == RowGuid.ToString()).FirstOrDefault();

            return p;
        }


        public virtual T GetItem(int id)
        {
            T copy = CreateItem();
            CopyData(Convert(_GetItem(id)), ref copy, AuthorisationGet);
            return copy;
        }


        public virtual T GetItemFromLocalId(int localid)
        {
            T copy = CreateItem();
            CopyData(Convert(_GetItemFromLocalId(localid)), ref copy, AuthorisationGet);
            return copy;
        }


        public T GetItem(Guid? RowGuid)
        {
            T copy = CreateItem();
            CopyData(Convert(_GetItem(RowGuid)), ref copy, AuthorisationGet);
            return copy;
        }


        public T GetItem(IRelationshipKey key)
        {
            if (key.Id.HasValue )
            {
                return GetItem(key.Id.Value);
            }
           else if (key.RowGuid.HasValue )
            {
                return GetItem(key.RowGuid);
            }
           else if (key.LocalId.HasValue)
            {
                return GetItemFromLocalId(key.LocalId.Value);
            }
            else
            {
                return default(T);
            }
        }

        public virtual T GetActiveItem(int id)
        {
            Z p = _GetActiveItems().Where(x => (x.Id == id)).FirstOrDefault();
            T copy = CreateItem();
            CopyData(Convert(p), ref copy, AuthorisationGet);
            return copy;
        }

        public Func<Z, object> defaultOrder{get; set; }
        
        public virtual IEnumerable<T> GetActiveItems ()
        {
            IEnumerable<Z> p = _GetActiveItems().OrderBy(defaultOrder);
            IEnumerable<T> copy = CopyData(p, AuthorisationGet);
            return copy;
        }


        protected IQueryable<Z> _GetActiveItems()
        {
            return dataset.Where(x => (x.IsDeleted == false));
        }

        protected IQueryable<Z> _GetAllItems()
        {
            return dataset;
        }

        public virtual IEnumerable<T> GetAllItems()
        {
            IEnumerable<Z> p = dataset.OrderBy(defaultOrder);
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

        protected internal IEnumerable<T> CopyData(IEnumerable<Z> original, Authorisation<T> a)
        {
            IList<T> retval = new List<T>();
            foreach (Z itm in original)
            {
                T r = CreateItem();
                CopyData(Convert(itm), ref r, a);
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

            Z r = dataset.Add(Convert(item));
            Repository.DataModel.SaveChanges();

            return GetDataStoredResponse(Convert(r));
        }

        public T ModifyItem(T item)
        {
            T itmtoupdate = GetItem(item.Id);
            
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
            T item = Convert(new Z());
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

