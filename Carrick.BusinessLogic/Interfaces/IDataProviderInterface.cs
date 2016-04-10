
using Carrick.DataModel;
using System;
using System.Collections.Generic;

namespace Carrick.BusinessLogic.Interfaces
{


    public interface IDataProviderInterface<T> where T : TableBase
    {
        //void Initialise();

        //void Sync();

        Type GetDataType();

        //void LoadLocalData();

        T InsertItem(T item);

        T ModifyItem(T item);

        T DeleteItem(T item);

        T GetItem(int id);

        T CreateItem();

        IEnumerable<T> GetAllItems();

        IEnumerable<T> GetActiveItems();
    }
}
