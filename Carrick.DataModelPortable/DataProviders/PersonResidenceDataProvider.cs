namespace ScoutDataModelPortable.DataProviders
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;

    public class PersonResidenceDataProvider : DataProviderBase<PersonResidence>
    {
        public PersonResidenceDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/personresidence");
            resolver = ResolveConflictFavourClient;
        }
    }
}