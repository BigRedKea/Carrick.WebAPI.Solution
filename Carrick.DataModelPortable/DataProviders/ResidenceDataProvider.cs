namespace ScoutDataModelPortable.DataProviders
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;

    public class ResidenceDataProvider : DataProviderBase<Residence>
    {
        public ResidenceDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/residence");
            resolver = ResolveConflictFavourClient;
        }
    }
}