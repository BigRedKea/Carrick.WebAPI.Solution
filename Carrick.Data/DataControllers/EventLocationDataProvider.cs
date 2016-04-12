namespace Carrick.ServerData.Controllers
{
    using BusinessLogic.Interfaces;
    using Carrick.Server.DataModel;

    public class EventLocationDataProvider : GenericDataProvider<IEventLocation, EventLocation>
    {
        internal EventLocationDataProvider(Repository r) : base(r, r.DataModel.EventLocations)
        {
        }

        protected internal override IEventLocation TransferSpecificProperties(IEventLocation original, ref IEventLocation destination, Authorisation<IEventLocation> Authorisation = null)
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


        public override EventLocation Convert(IEventLocation z)
        {
            return (EventLocation)z;
        }

        public override IEventLocation Convert(EventLocation z)
        {
            return z;
        }

    }
}