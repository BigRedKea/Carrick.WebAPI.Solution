using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrick.Data.Model
{
    public class EventLocation : TableBase
    {
        public int LocationId { get; set; }

        public Guid? LocationGuid { get; set; }

        public int ScoutingEventId { get; set; }

        public Guid? ScoutingEventGuid { get; set; }

        public DateTime? StartDateTime { get; set; }

        public DateTime? FinishDateTime { get; set; }
    }
}
