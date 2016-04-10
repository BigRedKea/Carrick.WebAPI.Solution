using System;


namespace ScoutDataModelPortable.DataProviders
{
    internal interface IClientDataProvider
    {
        void Sync();

        void Initialise();

        void LoadLocalData();

        Type GetDataType();
    }
}
