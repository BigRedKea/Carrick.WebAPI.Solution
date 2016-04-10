namespace ScoutDataModelPortable.DataProviders  
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;

    public class PersonBadgeDataProvider : DataProviderBase<PersonBadge>
    {
        public PersonBadgeDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/badgerequest");
            resolver = ResolveConflictFavourClient;
        }
    }
}
