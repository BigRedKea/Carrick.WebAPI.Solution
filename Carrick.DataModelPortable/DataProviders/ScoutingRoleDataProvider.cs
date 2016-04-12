namespace Carrick.ClientData.DataProviders
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;
    using BusinessLogic.Interfaces;
    public class ScoutingRoleDataProvider: DataProviderBase <IScoutingRole, ScoutingRole>
    {
        public ScoutingRoleDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("scoutingrole");
            resolver = ResolveConflictFavourClient;
        }

        public override ScoutingRole Convert(IScoutingRole z)
        {
            return (ScoutingRole)z;
        }

        public override IScoutingRole Convert(ScoutingRole z)
        {
            return z;
        }
    }
}
