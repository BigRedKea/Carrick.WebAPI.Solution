
namespace Carrick.DataModel

{
    using System;

    using BusinessLogic.Interfaces;

    public class EventLocation : TableBase, IEventLocation
    {
        public int LocationId { get; set; }
        public Guid? LocationGuid { get; set; }

        public int ScoutingEventId { get; set; }
        public Guid? ScoutingEventGuid { get; set; }

        public DateTime? StartDateTime { get; set; }

        public DateTime? FinishDateTime { get; set; }


        public IRelationshipKey LocationKey()
        {
            IRelationshipKey key = new RelationshipKey();
            key.Id = LocationId;
            key.RowGuid = LocationGuid;
            return key;
        }

        public IRelationshipKey ScoutingEventKey()
        {
            IRelationshipKey key = new RelationshipKey();
            key.Id = ScoutingEventId;
            key.RowGuid = ScoutingEventGuid;
            return key;
        }
    }
}
