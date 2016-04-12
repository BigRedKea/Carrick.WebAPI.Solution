namespace Carrick.ClientData.DataProviders  
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;
    using BusinessLogic.Interfaces;
    public class LocationDataProvider : DataProviderBase<ILocation, Location>
    {
        public LocationDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("location");
            resolver = ResolveConflictFavourClient;
        }

        public override Location Convert(ILocation z)
        {
            return (Location)z;
        }

        public override ILocation Convert(Location z)
        {
            return z;
        }
    }
}
