namespace Carrick.ClientData.DataProviders
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;

    public class PersonPersonDataProvider : DataProviderBase<PersonPerson>
    {
        public PersonPersonDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("personperson");
            resolver = ResolveConflictFavourClient;
        }
    }
}