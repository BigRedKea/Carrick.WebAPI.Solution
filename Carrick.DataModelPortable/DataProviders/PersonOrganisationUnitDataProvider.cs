namespace Carrick.ClientData.DataProviders
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;

    public class PersonOrganisationUnitDataProvider : DataProviderBase< PersonOrganisationUnit>
    {
        public PersonOrganisationUnitDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("personorganisationunit");
            resolver = ResolveConflictFavourClient;
        }
    }
}