namespace Carrick.ClientData.DataProviders
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;

    public class PersonSignInDataProvider : DataProviderBase<PersonSignIn>
    {
        public PersonSignInDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("personsignin");
            resolver = ResolveConflictFavourClient;
        }
    }
}