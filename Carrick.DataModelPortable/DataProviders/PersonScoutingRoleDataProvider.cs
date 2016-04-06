namespace ScoutDataModelPortable.DataProviders
{
    using System;
    using ScoutDataModelPortable.Model;
    using Scout.BusinessLogic.Interfaces;

    public class PersonScoutingRoleDataProvider : DataProviderBase<IPersonScoutingRole, PersonScoutingRole>
    {
        public PersonScoutingRoleDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/personscoutingrole");
            resolver = ResolveConflictFavourClient;
        }

        protected override IPersonScoutingRole InternalFactory()
        {
            IPersonScoutingRole r = new PersonScoutingRole();
            return r;
        }


        protected override IPersonScoutingRole Convert(PersonScoutingRole item)
        {
            return item;
        }
    }
}