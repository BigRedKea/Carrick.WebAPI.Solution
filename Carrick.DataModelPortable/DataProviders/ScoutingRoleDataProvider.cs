namespace ScoutDataModelPortable.DataProviders
{
    using System;
    using ScoutDataModelPortable.Model;
    using Scout.BusinessLogic.Interfaces;

    public class ScoutingRoleDataProvider: DataProviderBase <IScoutingRole, ScoutingRole>
    {
        public ScoutingRoleDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/scoutingrole");
            resolver = ResolveConflictFavourClient;
        }

        protected override IScoutingRole InternalFactory()
        {
            IScoutingRole r = new ScoutingRole();
            return r;
        }

        protected override IScoutingRole Convert(ScoutingRole item)
        {
            return item;
        }
    }
}
