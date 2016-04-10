﻿namespace ScoutDataModelPortable.DataProviders
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;

    public class PersonScoutingRoleDataProvider : DataProviderBase<PersonScoutingRole>
    {
        public PersonScoutingRoleDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/personscoutingrole");
            resolver = ResolveConflictFavourClient;
        }
    }
}