
using System;
using System.Collections.Generic;

namespace Scout.BusinessLogic.Interfaces
{

    public interface IDataProviderInterface
    {
        void Initialise();

        void Sync();

        Type GetDataType();

        void LoadLocalData();
    }

    public interface IDataProviderInterface<T> : IDataProviderInterface 
    {

        void InsertItem(T item);

        void ModifyItem(T item);

        void DeleteItem(T item);

        T GetItem(int id);

        T Factory();

        IEnumerable<T> GetItems();
    }
}
