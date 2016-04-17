namespace Carrick.Web.Models
{
    using Carrick.BusinessLogic.Interfaces;
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
    
        public int Id { get; set; }

        public Guid? RowGuid { get; set; } = Guid.NewGuid();

        public DateTime? RowCreated { get; set; }

        public DateTime? RowLastUpdated { get; set; }

        public DateTime? RowDeleted{ get; set; }

        public void PropertyChanged(string PropertyName, object value) 
        {
            PropertyChangedEventArgs args = new PropertyChangedEventArgs();
            args.PropertyName = PropertyName;
            args.value = value;
            PropertyChangedEvent(this, args);
        }

        public IRelationshipKey PrimaryKey()
        {
            RelationshipKey f = new RelationshipKey();
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
