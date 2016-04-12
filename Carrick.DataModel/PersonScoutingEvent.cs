namespace Carrick.DataModel
{
    using BusinessLogic.Interfaces;
    using SQLite.Net.Attributes;
    using System;

    [Table("PersonScoutingEvent")]
    public partial class PersonScoutingEvent :TableBase, IPersonScoutingEvent
    {
        public int? ScoutingEventId { get; set; }
        public Guid? ScoutingEventGuid { get; set; }

        public int? PersonId { get; set; }
        public Guid? PersonGuid { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public bool? RegisteredForEvent { get; set; }

        //[Column(TypeName = "money")]
        public decimal? MoneyPaid { get; set; }

        public bool PermissionReturned { get; set; }

        public int? NightsUnderCanvas { get; set; }

        public double? KilometersTravelled { get; set; }


        public IRelationshipKey ScoutingEventKey()
        {
            IRelationshipKey key = new RelationshipKey();
            key.Id = ScoutingEventId;
            key.RowGuid = ScoutingEventGuid;
            return key;
        }

        public IRelationshipKey PersonKey()
        {
            IRelationshipKey key = new RelationshipKey();
            key.Id = PersonId;
            key.RowGuid = PersonGuid;
            return key;
        }
    }
}
