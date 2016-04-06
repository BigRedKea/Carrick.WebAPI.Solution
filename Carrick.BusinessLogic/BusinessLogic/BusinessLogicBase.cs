using Scout.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scout.BusinessLogic.BusinessLogic
{
    public class BusinessLogicBase<T>
    {
        protected BusinessLogic _BL;

        private IDataProviderInterface<T> DataProvider;

        public BusinessLogicBase(BusinessLogic BL)
        {
            this._BL = BL;
            DataProvider = _BL.DataProviders.GetProvider<T>(typeof(T));
        }

        public T GetItem(Int32 id)
        {
            return DataProvider.GetItem(id);
        }

        public IEnumerable<T> GetItems()
        {
            return DataProvider.GetItems();
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

        public T Factory()
        {
            return DataProvider.Factory();
        }

    }
}
