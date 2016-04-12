namespace Carrick.ClientData.DataProviders
{
    using System;
    using Carrick.DataModel;
    using BusinessLogic.Interfaces;
    public class PersonSignInDataProvider : DataProviderBase<IPersonSignIn, PersonSignIn>
    {
        public PersonSignInDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("personsignin");
            resolver = ResolveConflictFavourClient;
        }

        public override PersonSignIn Convert(IPersonSignIn z)
        {
            return (PersonSignIn)z;
        }

        public override IPersonSignIn Convert(PersonSignIn z)
        {
            return z;
        }
    }
}