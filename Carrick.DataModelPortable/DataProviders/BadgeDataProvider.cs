namespace ScoutDataModelPortable.DataProviders  
{
    using System;
    using Carrick.DataModel;
    
    using SQLite.Net;
    public class BadgeDataProvider : DataProviderBase<Badge>
    {
        public BadgeDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/badge");
            resolver = ResolveConflictFavourClient;
        }

        //protected override IBadge InternalFactory()
        //{
        //    IBadge r = new Badge();
        //    return r;
        //}


    }
}
