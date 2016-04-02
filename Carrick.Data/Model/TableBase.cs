namespace Carrick.Data.Model
{
    using System;

    public class TableBase : ITableBase 
    {
        public TableBase ()
        {

        }

        public int Id { get; set; }

        public Guid? RowGuid { get; set; } = Guid.NewGuid();

        public bool IsDeleted { get; set; } = false;

        public DateTime? RowLastUpdated { get; set; }

        public DateTime? RowCreated { get; set; }

    }
}



