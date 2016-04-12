namespace Carrick.ClientData.DataProviders
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;

    public class PersonDataProvider : DataProviderBase<Person>
    {
        public PersonDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("person");
            resolver = ResolveConflictFavourClient;
        }
    }
}
