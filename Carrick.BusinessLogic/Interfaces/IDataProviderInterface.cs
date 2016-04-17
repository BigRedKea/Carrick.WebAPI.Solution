

using System;
using System.Collections.Generic;
using System.Linq;

namespace Carrick.BusinessLogic.Interfaces
{

    public interface IDataProviderInterface 
    {
        Type GetDataType();
    }

    public interface IDataProviderInterface<T> : IDataProviderInterface where T : ITableBase
    {
        //void Initialise();

        //void Sync();

        //void LoadLocalData();

        T InsertItem(T item);

        T ModifyItem(T item);

        T DeleteItem(T item);

        T GetItem(IRelationshipKey key);

        T CreateItem();

        IEnumerable<T> GetAllItems();

        IEnumerable<T> GetActiveItems();
        IRelationshipKey CreateRelationshipKey();
        T DeleteItem(IRelationshipKey key);

        Func<T, object> defaultOrder { get; }
    }
}
