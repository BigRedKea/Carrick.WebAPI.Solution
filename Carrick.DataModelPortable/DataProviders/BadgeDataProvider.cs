namespace ScoutDataModelPortable.DataProviders  
{
    using System;
    using ScoutDataModelPortable.Model;
    using Scout.BusinessLogic.Interfaces;
    using SQLite.Net;
    public class BadgeDataProvider : DataProviderBase<IBadge, Badge>
    {
        public BadgeDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/badge");
            resolver = ResolveConflictFavourClient;
        }

        protected override IBadge InternalFactory()
        {
            IBadge r = new Badge();
            return r;
        }

        protected override IBadge Convert(Badge item)
        {
            return item;
        }

    }
}
