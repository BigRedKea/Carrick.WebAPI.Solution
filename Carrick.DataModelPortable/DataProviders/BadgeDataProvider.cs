namespace ScoutDataModelPortable.DataProviders  
{
    using System;     
    using SQLite.Net;
    using Carrick.DataModel;

    public class BadgeDataProvider : DataProviderBase<Badge>
    {
        public BadgeDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/badge");
            resolver = ResolveConflictFavourClient;
        }
    }
}
