namespace ScoutDataModelPortable.DataProviders
{
    using System;
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