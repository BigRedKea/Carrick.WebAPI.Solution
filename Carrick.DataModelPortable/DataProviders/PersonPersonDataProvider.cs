namespace ScoutDataModelPortable.DataProviders
{
    using System;
    using ScoutDataModelPortable.Model;
    using Scout.BusinessLogic.Interfaces;

    public class PersonPersonDataProvider : DataProviderBase<IPersonPerson, PersonPerson>
    {
        public PersonPersonDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/personperson");
            resolver = ResolveConflictFavourClient;
        }

        protected override IPersonPerson InternalFactory()
        {
            IPersonPerson r = new PersonPerson();
            return r;
        }

        protected override IPersonPerson Convert(PersonPerson item)
        {
            return item;
        }
    }
}