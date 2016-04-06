namespace ScoutDataModelPortable.Model
{
    using SQLite.Net.Attributes;
    using System;
    using Scout.BusinessLogic.Interfaces;
    [Table("PersonScoutingEvent")]
    public partial class PersonScoutingEvent :TableBase, IPersonScoutingEvent
    {
        public int? ScoutingEventId { get; set; }

        public int? PersonId { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public bool? RegisteredForEvent { get; set; }

        public decimal? MoneyPaid { get; set; }

        public bool PermissionReturned { get; set; }

        public int? NightsUnderCanvas { get; set; }

        public double? KilometersTravelled { get; set; }
    }
}
