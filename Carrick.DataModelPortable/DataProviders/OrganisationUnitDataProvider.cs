namespace Carrick.ClientData.DataProviders  
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;
    using BusinessLogic.Interfaces;
    public class OrganisationUnitDataProvider : DataProviderBase<IOrganisationUnit, OrganisationUnit>
    {
        public OrganisationUnitDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("organisationunit");
            resolver = ResolveConflictFavourClient;
        }

        public override OrganisationUnit Convert(IOrganisationUnit z)
        {
            return (OrganisationUnit)z;
        }

        public override IOrganisationUnit Convert(OrganisationUnit z)
        {
            return z;
        }
    }


}
