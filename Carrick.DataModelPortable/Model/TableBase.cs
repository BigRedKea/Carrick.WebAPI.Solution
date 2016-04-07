namespace Carrick.DataModel
{
    
    using SQLite.Net.Attributes;
    using System;

    public delegate void PropertyChangedEventHandler(object sender, EventArgs e);

    public class TableBase
    {
        public TableBase()
        {
        }

        public event PropertyChangedEventHandler PropertyChangedEvent;

        [PrimaryKey, AutoIncrement]
        public int LocalId { get; set; }

        public int Id { get; set; }

        public Guid? RowGuid { get; set; } = Guid.NewGuid();

        public bool IsDeleted { get; set; } = false; 

        public bool IsDirty { get; set; } = false;

        public DateTime? RowLastUpdated { get; set; }

        public void PropertyChanged(string PropertyName, object value) 
        {
            PropertyChangedEventArgs args = new PropertyChangedEventArgs();
            args.PropertyName = PropertyName;
            args.value = value;
            PropertyChangedEvent(this, args);
        }
    }

    public class PropertyChangedEventArgs :EventArgs
    {
        public String PropertyName;

        public Object value;
    }

}
