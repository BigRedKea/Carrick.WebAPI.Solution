namespace ScoutDataModelPortable.DataProviders
{
    using System;
    using ScoutDataModelPortable.Model;
    using Scout.BusinessLogic.Interfaces;

    public class PersonResidenceDataProvider : DataProviderBase<IPersonResidence, PersonResidence>
    {
        public PersonResidenceDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/personresidence");
            resolver = ResolveConflictFavourClient;
        }

        protected override IPersonResidence InternalFactory()
        {
            IPersonResidence r = new PersonResidence();
            return r;
        }

        protected override IPersonResidence Convert(PersonResidence item)
        {
            return item;
        }
    }
}