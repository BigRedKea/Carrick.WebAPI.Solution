namespace ScoutDataModelPortable.DataProviders
{
    using System;
    using ScoutDataModelPortable.Model;
    using Scout.BusinessLogic.Interfaces;

    public class PersonDataProvider : DataProviderBase<IPerson, Person>
    {
        public PersonDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/person");
            resolver = ResolveConflictFavourClient;
        }

        protected override IPerson InternalFactory()
        {
            IPerson r = new Person();
            return r;
        }

        protected override IPerson Convert(Person item)
        {
            return item;
        }
    }
}
