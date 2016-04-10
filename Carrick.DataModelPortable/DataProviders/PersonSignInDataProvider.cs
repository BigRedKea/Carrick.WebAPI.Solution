namespace ScoutDataModelPortable.DataProviders
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;

    public class PersonSignInDataProvider : DataProviderBase<PersonSignIn>
    {
        public PersonSignInDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/personsignin");
            resolver = ResolveConflictFavourClient;
        }
    }
}