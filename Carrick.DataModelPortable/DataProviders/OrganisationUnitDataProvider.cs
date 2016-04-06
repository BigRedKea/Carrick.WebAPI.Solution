namespace ScoutDataModelPortable.DataProviders  
{
    using System;
    using ScoutDataModelPortable.Model;
    using Scout.BusinessLogic.Interfaces;

    public class OrganisationUnitDataProvider : DataProviderBase<IOrganisationUnit, OrganisationUnit >
    {
        public OrganisationUnitDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/organisationunit");
            resolver = ResolveConflictFavourClient;
        }

        protected override IOrganisationUnit InternalFactory()
        {
            IOrganisationUnit r = new OrganisationUnit();
            return r;
        }

        protected override IOrganisationUnit Convert(OrganisationUnit item)
        {
            return item;
        }
    }
}
