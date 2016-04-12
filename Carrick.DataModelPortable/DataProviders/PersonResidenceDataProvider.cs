namespace Carrick.ClientData.DataProviders
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;
    using BusinessLogic.Interfaces;
    public class PersonResidenceDataProvider : DataProviderBase<IPersonResidence, PersonResidence>
    {
        public PersonResidenceDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("personresidence");
            resolver = ResolveConflictFavourClient;
        }

        public override PersonResidence Convert(IPersonResidence z)
        {
            return (PersonResidence)z;
        }

        public override IPersonResidence Convert(PersonResidence z)
        {
            return z;
        }
    }
}