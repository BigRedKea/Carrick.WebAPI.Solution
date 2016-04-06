using System;

namespace Scout.BusinessLogic.Interfaces
{

    public interface IScoutingEvent : IDataTable
    {

        string EventName { get; set; }

        DateTime? StartDateTime { get; set; }

        DateTime? FinishDateTime { get; set; }

        DateTime? ClosingDateTime { get; set; }

        string LinkToMoreInformation { get; set; }

        bool? PatrolCampOrHike { get; set; }

        int? NominalKmWalked { get; set; }
    }
}
