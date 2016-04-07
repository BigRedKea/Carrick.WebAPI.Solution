namespace ScoutDataModelPortable.DataProviders
{
    using System;
    using Carrick.DataModel;
    

    public class ScoutingRoleDataProvider: DataProviderBase <ScoutingRole>
    {
        public ScoutingRoleDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/scoutingrole");
            resolver = ResolveConflictFavourClient;
        }

    }
}
