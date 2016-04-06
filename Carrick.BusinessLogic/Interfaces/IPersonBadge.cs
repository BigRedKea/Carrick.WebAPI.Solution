using System;

namespace Scout.BusinessLogic.Interfaces
{

    public interface IPersonBadge : IDataTable
    {
        int? BadgeId { get; set; }

        int? PersonId { get; set; }

        int? LeaderAssignedId { get; set; }

        int? AuthorisedById { get; set; }

        DateTime? PresentedDateTime { get; set; }

        int? OrderID { get; set; }

        bool? BadgeMissingFromOrder { get; set; }

    }
}
