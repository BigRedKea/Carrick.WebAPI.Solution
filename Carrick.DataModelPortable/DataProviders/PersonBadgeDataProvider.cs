namespace Carrick.ClientData.DataProviders  
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;
    using BusinessLogic.Interfaces;
    public class PersonBadgeDataProvider : DataProviderBase<IPersonBadge, PersonBadge>
    {
        public PersonBadgeDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("personbadge");
            resolver = ResolveConflictFavourClient;
        }

        public override PersonBadge Convert(IPersonBadge z)
        {
            return (PersonBadge)z;
        }

        public override IPersonBadge Convert(PersonBadge z)
        {
            return z;
        }
    }
}
