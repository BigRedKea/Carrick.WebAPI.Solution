
namespace Carrick.BusinessLogic.Interfaces
{
    using System;

    public interface IEventLocation : ITableBase
    {
        int LocationId { get; set; }
        Guid? LocationGuid { get; set; }

        int ScoutingEventId { get; set; }
        Guid? ScoutingEventGuid { get; set; }

        DateTime? StartDateTime { get; set; }

        DateTime? FinishDateTime { get; set; }

        IRelationshipKey LocationKey();

        IRelationshipKey ScoutingEventKey();

    }
}
