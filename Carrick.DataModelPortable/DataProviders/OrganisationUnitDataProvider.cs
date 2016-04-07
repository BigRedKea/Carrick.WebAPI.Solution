namespace ScoutDataModelPortable.DataProviders  
{
    using System;
    using Carrick.DataModel;
    

    public class OrganisationUnitDataProvider : DataProviderBase<OrganisationUnit>
    {
        public OrganisationUnitDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/organisationunit");
            resolver = ResolveConflictFavourClient;
        }

    }
}
