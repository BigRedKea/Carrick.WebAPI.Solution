namespace ScoutDataModelPortable.DataProviders
{
    using System;
    using ScoutDataModelPortable.Model;
    using Scout.BusinessLogic.Interfaces;

    public class PersonSignInDataProvider : DataProviderBase<IPersonSignIn, PersonSignIn>
    {
        public PersonSignInDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/personsignin");
            resolver = ResolveConflictFavourClient;
        }

        protected override IPersonSignIn InternalFactory()
        {
            IPersonSignIn r = new PersonSignIn();
            return r;
        }

        protected override IPersonSignIn Convert(PersonSignIn item)
        {
            return item;
        }
    }
}