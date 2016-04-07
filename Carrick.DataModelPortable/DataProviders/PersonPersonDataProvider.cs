namespace ScoutDataModelPortable.DataProviders
{
    using System;
    using Carrick.DataModel;
    

    public class PersonPersonDataProvider : DataProviderBase<PersonPerson>
    {
        public PersonPersonDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/personperson");
            resolver = ResolveConflictFavourClient;
        }

        //protected override PersonPerson InternalFactory()
        //{
        //    PersonPerson r = new PersonPerson();
        //    return r;
        //}

    }
}