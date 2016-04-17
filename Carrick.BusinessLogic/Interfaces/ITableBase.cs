

namespace Carrick.BusinessLogic.Interfaces
{
    using System;

    public interface ITableBase
    {

        int Id { get; set; }

        Guid? RowGuid { get; set; }

        DateTime? RowCreated { get; set; }

        DateTime? RowLastUpdated { get; set; }

        DateTime? RowDeleted { get; set; }

        IRelationshipKey PrimaryKey();

    }
}

