namespace Carrick.BusinessLogic.Interfaces
{
    using System;

    public interface IPersonBadge : ITableBase
    {

        int? BadgeId { get; set; }
        Guid? BadgeGuid { get; set; }

        int? PersonId { get; set; }
        Guid? PersonGuid { get; set; }

        int? LeaderAssignedId { get; set; }
        Guid? LeaderAssignedGuid { get; set; }

        int? AuthorisedById { get; set; }
        Guid? AuthorisedByGuid { get; set; }

        DateTime? PresentedTimeStamp { get; set; }

        int? OrderID { get; set; }

        bool? BadgeMissingFromOrder { get; set; }

        IRelationshipKey BadgeKey();

        IRelationshipKey PersonKey();

        IRelationshipKey LeaderAssignedKey();

        IRelationshipKey AuthorisedByKey();

    }
}
