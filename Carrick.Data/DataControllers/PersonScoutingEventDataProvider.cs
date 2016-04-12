namespace Carrick.ServerData.Controllers
{
    using BusinessLogic.Interfaces;
    using Carrick.Server.DataModel;

    public class PersonScoutingEventDataProvider : GenericDataProvider<IPersonScoutingEvent, PersonScoutingEvent>
    {
        internal PersonScoutingEventDataProvider(Repository r) : base(r, r.DataModel.PersonAtEvents)
        {
        }

        protected internal override IPersonScoutingEvent TransferSpecificProperties(IPersonScoutingEvent original,ref  IPersonScoutingEvent destination, Authorisation<IPersonScoutingEvent> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = CreateItem(); }
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
