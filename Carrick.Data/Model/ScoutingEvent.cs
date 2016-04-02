namespace Carrick.Data.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ScoutingEvent")]
    public partial class ScoutingEvent : TableBase
    {

        [StringLength(128)]
        public string EventName { get; set; }

        public DateTime? StartDateTime { get; set; }

        public DateTime? FinishDateTime { get; set; }

        public DateTime? ClosingDateTime { get; set; }

        public string LinkToMoreInformation { get; set; }

        public bool? PatrolCampOrHike { get; set; }

        public int? NominalKmWalked { get; set; }
    }
}
