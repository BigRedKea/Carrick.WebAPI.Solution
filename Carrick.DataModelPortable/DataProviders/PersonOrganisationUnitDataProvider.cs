namespace ScoutDataModelPortable.DataProviders
{
    using System;
    using ScoutDataModelPortable.Model;
    using Scout.BusinessLogic.Interfaces;

    public class PersonOrganisationUnitDataProvider : DataProviderBase<IPersonOrganisationUnit, PersonOrganisationUnit>
    {
        public PersonOrganisationUnitDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/personorganisationunit");
            resolver = ResolveConflictFavourClient;
        }

        protected override IPersonOrganisationUnit InternalFactory()
        {
            IPersonOrganisationUnit r = new PersonOrganisationUnit();
            return r;
        }

        protected override IPersonOrganisationUnit Convert(PersonOrganisationUnit item)
        {
            return item;
        }
    }
}