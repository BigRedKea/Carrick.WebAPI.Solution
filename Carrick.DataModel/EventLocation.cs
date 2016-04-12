
namespace Carrick.DataModel

{
    using System;
    using SQLite.Net.Attributes;

    public class EventLocation : TableBase
    {
        public int LocationId { get; set; }
        public Guid? LocationGuid { get; set; }

        public int ScoutingEventId { get; set; }
        public Guid? ScoutingEventGuid { get; set; }

        public DateTime? StartDateTime { get; set; }

        public DateTime? FinishDateTime { get; set; }


        public RelationshipKey LocationKey()
        {
            RelationshipKey key = new RelationshipKey();
            key.Id = LocationId;
            key.RowGuid = LocationGuid;
            return key;
        }

        public RelationshipKey ScoutingEventKey()
        {
            RelationshipKey key = new RelationshipKey();
            key.Id = ScoutingEventId;
            key.RowGuid = ScoutingEventGuid;
            return key;
        }
    }
}
