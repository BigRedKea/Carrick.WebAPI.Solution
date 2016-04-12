

using System;
using System.Collections.Generic;
using System.Linq;

namespace Carrick.BusinessLogic.Interfaces
{

    public interface IDataProviderInterface<T> where T : ITableBase
    {
        //void Initialise();

        //void Sync();

        Type GetDataType();

        //void LoadLocalData();

        T InsertItem(T item);

        T ModifyItem(T item);

        T DeleteItem(T item);

        T GetItem(int id);

        T GetItem(Guid? uniqueId);

        T GetItem(IRelationshipKey key);

        T CreateItem();

        IEnumerable<T> GetAllItems();

        IEnumerable<T> GetActiveItems();
    }
}
