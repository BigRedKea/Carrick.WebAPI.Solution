﻿namespace Carrick.Data.Controllers
{
    using Carrick.DataModel;


    public class EventLocationDataProvider : GenericDataProvider<EventLocation>
    {
        internal EventLocationDataProvider(Repository r) : base(r, r.DataModel.EventLocations)
        {
        }

        protected internal override EventLocation TransferSpecificProperties(EventLocation original, ref EventLocation destination, Authorisation<EventLocation> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = new EventLocation(); }

            destination.LocationId = original.LocationId;
            destination.LocationGuid = original.LocationGuid;
            destination.ScoutingEventId = original.ScoutingEventId;
            destination.ScoutingEventGuid = original.ScoutingEventGuid;
            destination.StartDateTime = original.StartDateTime;
            destination.FinishDateTime = original.FinishDateTime;
            return destination;
        }

    }
}