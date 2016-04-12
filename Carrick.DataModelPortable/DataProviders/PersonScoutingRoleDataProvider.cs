namespace Carrick.ClientData.DataProviders
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;
    using BusinessLogic.Interfaces;
    public class PersonScoutingRoleDataProvider : DataProviderBase<IPersonScoutingRole,PersonScoutingRole>
    {
        public PersonScoutingRoleDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("personscoutingrole");
            resolver = ResolveConflictFavourClient;
        }

        public override PersonScoutingRole Convert(IPersonScoutingRole z)
        {
            return (PersonScoutingRole)z;
        }

        public override IPersonScoutingRole Convert(PersonScoutingRole z)
        {
            return z;
        }
    }
}