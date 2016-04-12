namespace Carrick.ClientData.DataProviders  
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;

    public class PersonBadgeDataProvider : DataProviderBase<PersonBadge>
    {
        public PersonBadgeDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("badgerequest");
            resolver = ResolveConflictFavourClient;
        }
    }
}
