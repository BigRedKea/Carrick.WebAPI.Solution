namespace Carrick.ClientData.DataProviders  
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;
    using BusinessLogic.Interfaces;

    public class BadgeDataProvider : DataProviderBase<IBadge, Badge>
    {
        public BadgeDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("badge");
            resolver = ResolveConflictFavourClient;
        }

        public override Badge Convert(IBadge z)
        {
            return (Badge)z;
        }

        public override IBadge Convert(Badge z)
        {
            return z;
        }
    }
}
