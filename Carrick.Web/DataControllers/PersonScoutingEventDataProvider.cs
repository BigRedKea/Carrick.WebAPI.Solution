namespace Carrick.ServerData.Controllers
{
    using Carrick.BusinessLogic.Interfaces;
    using Carrick.Web.Models;

    public class PersonScoutingEventDataProvider : GenericDataProvider<IPersonScoutingEvent, PersonScoutingEvent>
    {
        internal PersonScoutingEventDataProvider(Repository r) : base(r, r.DataModel.PersonAtEvents)
        {
        }

        protected internal override IPersonScoutingEvent TransferSpecificProperties(IPersonScoutingEvent original,ref  PersonScoutingEvent destination, Authorisation<IPersonScoutingEvent> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = Convert(CreateItem()); }
            destination.ScoutingEventId = original.ScoutingEventId;
            destination.ScoutingEventGuid = original.ScoutingEventGuid;
            destination.RegistrationDate = original.RegistrationDate;
            destination.RegisteredForEvent = original.RegisteredForEvent;
            destination.MoneyPaid = original.MoneyPaid;
            destination.PermissionReturned = original.PermissionReturned;
            destination.NightsUnderCanvas = original.NightsUnderCanvas;
            destination.KilometersTravelled = original.KilometersTravelled;
            return destination;
        }


        public override PersonScoutingEvent Convert(IPersonScoutingEvent z)
        {
            return (PersonScoutingEvent)z;
        }

        public override IPersonScoutingEvent Convert(PersonScoutingEvent z)
        {
            return z;
        }
    }
}
