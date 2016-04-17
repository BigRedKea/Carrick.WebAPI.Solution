namespace Carrick.ClientData.DataProviders  
{
    using Carrick.BusinessLogic.Interfaces;
    using Carrick.DataModel;

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


        public override System.Func<IBadge, object> defaultOrder
        {
            get
            {
                return (IBadge t) => t.BadgeSort;
            }
        }
    }
}
