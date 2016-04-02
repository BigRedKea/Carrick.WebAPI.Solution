namespace Carrick.Data.Model
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PersonScoutingEvent")]
    public partial class PersonScoutingEvent :TableBase
    {
        public int? ScoutingEventId { get; set; }

        public Guid? ScoutingEventGuid { get; set; }

        public int? PersonId { get; set; }

        public Guid? PersonGuid { get; set; }

        public DateTime? RegistrationDate { get; set; }

        public bool? RegisteredForEvent { get; set; }

        [Column(TypeName = "money")]
        public decimal? MoneyPaid { get; set; }

        public bool PermissionReturned { get; set; }

        public int? NightsUnderCanvas { get; set; }

        public double? KilometersTravelled { get; set; }
    }
}
