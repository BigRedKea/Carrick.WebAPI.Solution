
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carrick.BusinessLogic.Interfaces;


namespace Carrick.BusinessLogic.BusinessLogic
{
    public class BusinessLogicBase<T> where T : ITableBase
    {
        protected BusinessLogic _BL;

        private IDataProviderInterface<T> DataProvider;

        public BusinessLogicBase(BusinessLogic BL)
        {
            this._BL = BL;
            DataProvider = (IDataProviderInterface<T>) _BL.DataProviders.GetProvider(typeof(T));
        }

        public T GetItem(int id)
        {
            return DataProvider.GetItem(id);
        }

        public IEnumerable<T> GetAllItems()
        {
            return DataProvider.GetAllItems();
        }

        public IEnumerable<T> GetActiveItems()
        {
            return DataProvider.GetActiveItems();
        }

        public void ModifyItem(T item)
        {
            DataProvider.ModifyItem(item);
        }

        public void InsertItem(T item)
        {
            DataProvider.InsertItem(item);
        }

        public void DeleteItem(T item)
        {
            DataProvider.DeleteItem(item);
        }

        public T CreateItem()
        {
            return DataProvider.CreateItem();
        }

    }
}
