

namespace Carrick.BusinessLogic.Interfaces
{
    using System;

    public interface ITableBase
    {

        //int LocalId { get; set; }

        int Id { get; set; }

        Guid? RowGuid { get; set; }

        bool IsDeleted { get; set; }

        //bool? IsDirty { get; set; }

        DateTime? RowLastUpdated { get; set; }

        DateTime? RowCreated { get; set; }

        IRelationshipKey PrimaryKey();

    }
}

