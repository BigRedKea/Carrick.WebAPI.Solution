namespace Carrick.Server.DataModel
{
    using BusinessLogic.Interfaces;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public delegate void PropertyChangedEventHandler(object sender, EventArgs e);

    public class TableBase :ITableBase
    {
        public TableBase()
        {
        }

        public event PropertyChangedEventHandler PropertyChangedEvent;

        //[PrimaryKey, AutoIncrement]
        public int LocalId { get; set; }

      
        public int Id { get; set; }

        public Guid? RowGuid { get; set; } = Guid.NewGuid();

        public bool IsDeleted { get; set; } = false; 

        public bool IsDirty { get; set; } = false;

        public DateTime? RowLastUpdated { get; set; }

        public DateTime? RowCreated { get; set; }

        public void PropertyChanged(string PropertyName, object value) 
        {
            PropertyChangedEventArgs args = new PropertyChangedEventArgs();
            args.PropertyName = PropertyName;
            args.value = value;
            PropertyChangedEvent(this, args);
        }

        public RelationshipKey PrimaryKey()
        {
            RelationshipKey f = new RelationshipKey();
            f.LocalId = LocalId;
            f.Id = Id;
            f.RowGuid = RowGuid;
            return f;
        }
    }

    public class PropertyChangedEventArgs :EventArgs
    {
        public String PropertyName;

        public Object value;
    }



}
