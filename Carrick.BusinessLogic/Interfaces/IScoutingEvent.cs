namespace Carrick.BusinessLogic.Interfaces
{
    using System;
    public interface IScoutingEvent : ITableBase
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
