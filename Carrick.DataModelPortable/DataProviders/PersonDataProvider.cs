namespace ScoutDataModelPortable.DataProviders
{
    using System;
    using Carrick.DataModel;
    

    public class PersonDataProvider : DataProviderBase<Person>
    {
        public PersonDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/person");
            resolver = ResolveConflictFavourClient;
        }

    }
}
