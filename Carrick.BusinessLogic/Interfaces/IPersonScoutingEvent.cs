using System;

namespace Scout.BusinessLogic.Interfaces
{

    public interface IPersonScoutingEvent : IDataTable
    {
        int? ScoutingEventId { get; set; }

        int? PersonId { get; set; }

        DateTime? RegistrationDate { get; set; }

        bool? RegisteredForEvent { get; set; }

        decimal? MoneyPaid { get; set; }

        bool PermissionReturned { get; set; }

        int? NightsUnderCanvas { get; set; }

        double? KilometersTravelled { get; set; }
    }
}
