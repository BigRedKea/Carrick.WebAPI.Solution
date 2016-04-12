﻿namespace Carrick.ServerData.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using Carrick.Server.DataModel;
    using BusinessLogic.Interfaces;
    public class ScoutingEventDataProvider : GenericDataProvider<IScoutingEvent, ScoutingEvent>
    {
        internal ScoutingEventDataProvider(Repository r) : base(r, r.DataModel.ScoutingEvents)
        {
            defaultOrder = (x => x.StartDateTime);
        }

        protected internal override IScoutingEvent TransferSpecificProperties(IScoutingEvent original, ref IScoutingEvent destination, Authorisation<IScoutingEvent> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = CreateItem();  }
            destination.EventName = original.EventName;
            destination.StartDateTime = original.StartDateTime;
            destination.FinishDateTime = original.FinishDateTime;
            destination.ClosingDateTime = original.ClosingDateTime;
            destination.LinkToMoreInformation = original.LinkToMoreInformation;
            destination.PatrolCampOrHike = original.PatrolCampOrHike;
            destination.NominalKmWalked = original.NominalKmWalked;

            return destination;
        }

        public override ScoutingEvent Convert(IScoutingEvent z)
        {
            return (ScoutingEvent)z;
        }

        public override IScoutingEvent Convert(ScoutingEvent z)
        {
            return z;
        }
    }
}
