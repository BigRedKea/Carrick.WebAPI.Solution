namespace Carrick.ClientData.DataProviders  
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;
    using BusinessLogic.Interfaces;
    public class EventLocationDataProvider : DataProviderBase<IEventLocation, EventLocation>
    {
        public EventLocationDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("eventlocation");
            resolver = ResolveConflictFavourClient;
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
