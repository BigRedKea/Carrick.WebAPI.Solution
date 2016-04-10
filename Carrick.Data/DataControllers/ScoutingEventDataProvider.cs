namespace Carrick.ServerData.Controllers
{
    using Carrick.DataModel;
    using System.Collections.Generic;
    using System.Linq;
    public class ScoutingEventDataProvider : GenericDataProvider<ScoutingEvent>
    {
        internal ScoutingEventDataProvider(Repository r) : base(r, r.DataModel.ScoutingEvents)
        {
        }

        public override IEnumerable<ScoutingEvent> GetActiveItems()
        {
            IEnumerable<ScoutingEvent> p = dataset.Where(x => (x.IsDeleted == false)).OrderBy(x => x.StartDateTime);
            IEnumerable<ScoutingEvent> copy = CopyData(p, AuthorisationGet);
            return copy;
        }

        public override IEnumerable<ScoutingEvent> GetAllItems()
        {
            IEnumerable<ScoutingEvent> p = dataset.OrderBy(x => x.StartDateTime.HasValue).ThenBy(x => x.StartDateTime);
            IEnumerable<ScoutingEvent> copy = CopyData(p, AuthorisationGet);
            return copy;
        }


        protected internal override ScoutingEvent TransferSpecificProperties(ScoutingEvent original, ref ScoutingEvent destination, Authorisation<ScoutingEvent> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = new ScoutingEvent();  }
            destination.EventName = original.EventName;
            destination.StartDateTime = original.StartDateTime;
            destination.FinishDateTime = original.FinishDateTime;
            destination.ClosingDateTime = original.ClosingDateTime;
            destination.LinkToMoreInformation = original.LinkToMoreInformation;
            destination.PatrolCampOrHike = original.PatrolCampOrHike;
            destination.NominalKmWalked = original.NominalKmWalked;

            return destination;
        }
    }
}
