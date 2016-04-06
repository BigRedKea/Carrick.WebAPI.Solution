
namespace Carrick.Data.Model

{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Scout.BusinessLogic.Interfaces;

    public class EventLocation : TableBase, IEventLocation
    {
        public int LocationId { get; set; }

        public Guid? LocationGuid { get; set; }

        public int ScoutingEventId { get; set; }

        public Guid? ScoutingEventGuid { get; set; }

        public DateTime? StartDateTime { get; set; }

        public DateTime? FinishDateTime { get; set; }
    }
}
