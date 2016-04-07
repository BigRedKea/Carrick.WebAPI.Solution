namespace ScoutDataModelPortable.DataProviders
{
    using System;
    using Carrick.DataModel;
    

    public class ScoutingEventDataProvider : DataProviderBase<ScoutingEvent>
    {
        public ScoutingEventDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/ScoutingEvent");
            resolver = ResolveConflictFavourClient;
        }

    }
}