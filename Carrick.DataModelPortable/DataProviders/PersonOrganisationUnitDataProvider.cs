namespace ScoutDataModelPortable.DataProviders
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;

    public class PersonOrganisationUnitDataProvider : DataProviderBase< PersonOrganisationUnit>
    {
        public PersonOrganisationUnitDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/personorganisationunit");
            resolver = ResolveConflictFavourClient;
        }
    }
}