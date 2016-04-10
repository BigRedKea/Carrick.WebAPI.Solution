namespace ScoutDataModelPortable.DataProviders
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;

    public class PersonScoutingEventDataProvider : DataProviderBase< PersonScoutingEvent>
    {
        public PersonScoutingEventDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/personScoutingEvent");
            resolver = ResolveConflictFavourClient;
        }
    }
}