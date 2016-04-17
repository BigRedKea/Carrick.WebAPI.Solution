
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carrick.BusinessLogic.Interfaces;


namespace Carrick.BusinessLogic
{
    public class BusinessLogicBase<T> where T : ITableBase
    {
        protected BusinessLogic _BL;

        public IDataProviderInterface<T> DataProvider;

        public BusinessLogicBase(BusinessLogic BL)
        {
            this._BL = BL;
            DataProvider = (IDataProviderInterface<T>) _BL.DataProviders.GetProvider(typeof(T));
        }

        public T GetItem(int id)
        {
            IRelationshipKey key = DataProvider.CreateRelationshipKey();
            return GetItem(key);
        }

        public T GetItem(IRelationshipKey key)
        {
            return DataProvider.GetItem(key);
        }

        public IEnumerable<T> GetAllItems()
        {
            return DataProvider.GetAllItems();
        }

        public IEnumerable<T> GetActiveItems()
        {
            return DataProvider.GetActiveItems();
        }

        public T ModifyItem(T item)
        {
            return DataProvider.ModifyItem(item);
        }

        public T InsertItem(T item)
        {
            return DataProvider.InsertItem(item);
        }

        public T DeleteItem(T item)
        {
            return DataProvider.DeleteItem(item);
        }

        public T DeleteItem(int id)
        {
            IRelationshipKey key = DataProvider.CreateRelationshipKey();
            key.Id = id;
            return DataProvider.DeleteItem(key);
            
        }

        public T CreateItem()
        {
            return DataProvider.CreateItem();
        }

        public IEnumerable<T> GetUpdatedItems(DateTime d)
        {
            throw new NotImplementedException();
        }

    }
}
