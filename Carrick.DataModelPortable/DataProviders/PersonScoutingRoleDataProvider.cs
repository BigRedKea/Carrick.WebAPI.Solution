namespace Carrick.ClientData.DataProviders
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;

    public class PersonScoutingRoleDataProvider : DataProviderBase<PersonScoutingRole>
    {
        public PersonScoutingRoleDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("personscoutingrole");
            resolver = ResolveConflictFavourClient;
        }
    }
}