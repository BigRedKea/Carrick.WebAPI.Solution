namespace Carrick.Data.Model
{
    using Scout.BusinessLogic.Interfaces;
    using System;

    public class TableBase : IDataTable
    {
        public TableBase ()
        {

        }

        public int Id { get; set; }

        public int LocalId { get; set; }

        public Guid? RowGuid { get; set; } = Guid.NewGuid();

        public bool IsDeleted { get; set; } = false;

        public bool IsDirty { get; set; }

        public DateTime? RowLastUpdated { get; set; }

        public DateTime? RowCreated { get; set; }

    }
}



