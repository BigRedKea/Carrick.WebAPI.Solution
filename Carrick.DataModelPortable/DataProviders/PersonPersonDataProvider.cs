namespace Carrick.ClientData.DataProviders
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;
    using BusinessLogic.Interfaces;
    public class PersonPersonDataProvider : DataProviderBase<IPersonPerson,PersonPerson>
    {
        public PersonPersonDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("personperson");
            resolver = ResolveConflictFavourClient;
        }

        public override PersonPerson Convert(IPersonPerson z)
        {
            return (PersonPerson)z;
        }

        public override IPersonPerson Convert(PersonPerson z)
        {
            return z;
        }
    }
}