namespace ScoutDataModelPortable.DataProviders
{
    using System;
    using ScoutDataModelPortable.Model;
    using Scout.BusinessLogic.Interfaces;

    public class ResidenceDataProvider : DataProviderBase<IResidence, Residence>
    {
        public ResidenceDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/residence");
            resolver = ResolveConflictFavourClient;
        }

        protected override IResidence InternalFactory()
        {
            IResidence r = new Residence();
            return r;
        }


        protected override IResidence Convert(Residence item)
        {
            return item;
        }
    }
}