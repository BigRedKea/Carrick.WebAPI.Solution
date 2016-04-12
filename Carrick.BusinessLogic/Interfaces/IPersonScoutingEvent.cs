namespace Carrick.BusinessLogic.Interfaces
{
    using System;
    public interface IPersonScoutingEvent : ITableBase
    {
        int? ScoutingEventId { get; set; }
        Guid? ScoutingEventGuid { get; set; }

        int? PersonId { get; set; }
        Guid? PersonGuid { get; set; }

        DateTime? RegistrationDate { get; set; }

        bool? RegisteredForEvent { get; set; }

        //[Column(TypeName = "money")]
        decimal? MoneyPaid { get; set; }

        bool PermissionReturned { get; set; }

        int? NightsUnderCanvas { get; set; }

        double? KilometersTravelled { get; set; }

        IRelationshipKey ScoutingEventKey();

        IRelationshipKey PersonKey();
    }
}
