namespace Carrick.ClientData.DataProviders
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;
    using BusinessLogic.Interfaces;
    public class PersonDataProvider : DataProviderBase<IPerson, Person>
    {
        public PersonDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("person");
            resolver = ResolveConflictFavourClient;
        }

        public override Person Convert(IPerson z)
        {
            return (Person)z;
        }

        public override IPerson Convert(Person z)
        {
            return z;
        }
    }
}
