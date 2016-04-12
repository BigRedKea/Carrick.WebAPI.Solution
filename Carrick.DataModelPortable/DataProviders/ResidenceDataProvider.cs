namespace Carrick.ClientData.DataProviders
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;
    using BusinessLogic.Interfaces;

    public class ResidenceDataProvider : DataProviderBase<IResidence, Residence>
    {
        public ResidenceDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("residence");
            resolver = ResolveConflictFavourClient;
        }

        public override Residence Convert(IResidence z)
        {
            return (Residence)z;
        }

        public override IResidence Convert(Residence z)
        {
            return z;
        }
    }
}