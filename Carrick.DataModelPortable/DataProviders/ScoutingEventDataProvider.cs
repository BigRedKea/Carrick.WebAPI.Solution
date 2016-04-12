namespace Carrick.ClientData.DataProviders
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;
    using BusinessLogic.Interfaces;
    public class ScoutingEventDataProvider : DataProviderBase<IScoutingEvent, ScoutingEvent>
    {
        public ScoutingEventDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("scoutingevent");
            resolver = ResolveConflictFavourClient;
        }

        public override ScoutingEvent Convert(IScoutingEvent z)
        {
            return (ScoutingEvent)z;
        }

        public override IScoutingEvent Convert(ScoutingEvent z)
        {
            return z;
        }
    }
}