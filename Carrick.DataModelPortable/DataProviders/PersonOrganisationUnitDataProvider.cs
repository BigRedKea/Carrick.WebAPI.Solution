namespace Carrick.ClientData.DataProviders
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;
    using BusinessLogic.Interfaces;
    public class PersonOrganisationUnitDataProvider : DataProviderBase<IPersonOrganisationUnit, PersonOrganisationUnit>
    {
        public PersonOrganisationUnitDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("personorganisationunit");
            resolver = ResolveConflictFavourClient;
        }

        public override PersonOrganisationUnit Convert(IPersonOrganisationUnit z)
        {
            return (PersonOrganisationUnit)z;
        }

        public override IPersonOrganisationUnit Convert(PersonOrganisationUnit z)
        {
            return z;
        }
    }
}