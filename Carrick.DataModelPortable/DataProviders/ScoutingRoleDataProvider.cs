namespace Carrick.ClientData.DataProviders
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;

    public class ScoutingRoleDataProvider: DataProviderBase <ScoutingRole>
    {
        public ScoutingRoleDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("scoutingrole");
            resolver = ResolveConflictFavourClient;
        }
    }
}
