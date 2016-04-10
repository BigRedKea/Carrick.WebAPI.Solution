﻿namespace Carrick.ServerData.Controllers
{
    using Carrick.DataModel;
    public class PersonScoutingEventDataProvider : GenericDataProvider<PersonScoutingEvent>
    {
        internal PersonScoutingEventDataProvider(Repository r) : base(r, r.DataModel.PersonAtEvents)
        {
        }

        protected internal override PersonScoutingEvent TransferSpecificProperties(PersonScoutingEvent original,ref  PersonScoutingEvent destination, Authorisation<PersonScoutingEvent> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = new PersonScoutingEvent(); }
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
    }
}
