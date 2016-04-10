namespace ScoutDataModelPortable.DataProviders  
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;

    public class LocationDataProvider : DataProviderBase<EventLocation>
    {
        public LocationDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/eventlocation");
            resolver = ResolveConflictFavourClient;
        }
    }
}
