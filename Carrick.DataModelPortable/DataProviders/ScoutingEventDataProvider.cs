﻿namespace Carrick.ClientData.DataProviders
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;

    public class ScoutingEventDataProvider : DataProviderBase<ScoutingEvent>
    {
        public ScoutingEventDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("scoutingevent");
            resolver = ResolveConflictFavourClient;
        }
    }
}