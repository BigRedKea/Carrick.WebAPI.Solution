using Carrick.BusinessLogic.Interfaces;
using System;


namespace Carrick.ClientData.DataProviders
{
    internal interface IClientDataProvider : IDataProviderInterface
    {
        void Sync();

        void Initialise();

        void LoadLocalData();

    }
}
