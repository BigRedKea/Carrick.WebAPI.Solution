namespace Carrick.Data.Controllers
{
    using Carrick.Data.Model;
    using System.Linq;
    public class ScoutingEventDataController : GenericDataController<ScoutingEvent>
    {
        internal ScoutingEventDataController(Repository r) : base(r, r.DataModel.ScoutingEvents)
        {
        }

        public override ScoutingEvent[] GetActiveItems()
        {
            ScoutingEvent[] p = dataset.Where(x => (x.IsDeleted == false)).OrderBy(x => x.StartDateTime).ToArray<ScoutingEvent>();
            ScoutingEvent[] copy = CopyData(p, AuthorisationGet);
            return copy;
        }

        public override ScoutingEvent[] GetAllItems()
        {
            ScoutingEvent[] p = dataset.OrderBy(x => x.StartDateTime.HasValue).ThenBy(x => x.StartDateTime).ToArray<ScoutingEvent>();
            ScoutingEvent[] copy = CopyData(p, AuthorisationGet);
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
