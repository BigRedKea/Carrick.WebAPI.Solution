namespace Carrick.ClientData.DataProviders  
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;

    public class LocationDataProvider : DataProviderBase<Location>
    {
        public LocationDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("location");
            resolver = ResolveConflictFavourClient;
        }
    }
}
