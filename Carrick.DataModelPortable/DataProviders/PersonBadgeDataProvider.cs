namespace ScoutDataModelPortable.DataProviders  
{
    using System;
    using ScoutDataModelPortable.Model;
    using Scout.BusinessLogic.Interfaces;

    public class PersonBadgeDataProvider : DataProviderBase<IPersonBadge, PersonBadge>
    {
        public PersonBadgeDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/badgerequest");
            resolver = ResolveConflictFavourClient;
        }

        protected override IPersonBadge InternalFactory()
        {
            IPersonBadge r = new PersonBadge();
            return r;
        }

        protected override IPersonBadge Convert(PersonBadge item)
        {
            return item;
        }
    }
}
