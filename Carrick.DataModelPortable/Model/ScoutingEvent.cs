namespace ScoutDataModelPortable.Model
{
    using SQLite.Net.Attributes;
    using System;
    using Scout.BusinessLogic.Interfaces;
    [Table("ScoutingEvent")]
    public partial class ScoutingEvent : TableBase, IScoutingEvent
    {

        [MaxLength(128)]
        public string EventName { get; set; }

        public DateTime? StartDateTime { get; set; }

        public DateTime? FinishDateTime { get; set; }

        public DateTime? ClosingDateTime { get; set; }

        public string LinkToMoreInformation { get; set; }

        public bool? PatrolCampOrHike { get; set; }

        public int? NominalKmWalked { get; set; }
    }
}
