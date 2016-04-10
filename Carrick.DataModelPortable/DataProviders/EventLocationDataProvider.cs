namespace ScoutDataModelPortable.DataProviders  
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;

    public class EventLocationDataProvider : DataProviderBase<EventLocation>
    {
        public EventLocationDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/eventlocation");
            resolver = ResolveConflictFavourClient;
        }
    }
}
