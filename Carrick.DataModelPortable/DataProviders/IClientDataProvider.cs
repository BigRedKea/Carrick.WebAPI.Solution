using System;


namespace Carrick.ClientData.DataProviders
{
    internal interface IClientDataProvider
    {
        void Sync();

        void Initialise();

        void LoadLocalData();

        Type GetDataType();
    }
}
