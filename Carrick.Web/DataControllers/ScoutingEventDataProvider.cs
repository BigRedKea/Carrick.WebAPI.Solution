namespace Carrick.ServerData.Controllers
{
    using System.Collections.Generic;
    using System.Linq;

    using BusinessLogic.Interfaces;
    using Web.Models;
    using System;
    public class ScoutingEventDataProvider : GenericDataProvider<IScoutingEvent, ScoutingEvent>
    {
        internal ScoutingEventDataProvider(Repository r) : base(r, r.DataModel.ScoutingEvents)
        {

        }

        public override Func<IScoutingEvent, object> defaultOrder
        {
            get
            {
                return (x => x.StartDateTime);
            }
        }

        protected internal override IScoutingEvent TransferSpecificProperties(IScoutingEvent original, ref ScoutingEvent destination, Authorisation<IScoutingEvent> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = Convert(CreateItem());  }
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
