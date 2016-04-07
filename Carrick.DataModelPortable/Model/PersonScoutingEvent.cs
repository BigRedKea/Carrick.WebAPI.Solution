namespace Carrick.DataModel
{
    using SQLite.Net.Attributes;
    using System;
    
    [Table("PersonScoutingEvent")]
    public partial class PersonScoutingEvent :TableBase
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
