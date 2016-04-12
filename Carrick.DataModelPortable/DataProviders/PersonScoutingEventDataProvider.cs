namespace Carrick.ClientData.DataProviders
{
    using System;
    using SQLite.Net;
    using Carrick.DataModel;
    using BusinessLogic.Interfaces;
    public class PersonScoutingEventDataProvider : DataProviderBase<IPersonScoutingEvent, PersonScoutingEvent>
    {
        public PersonScoutingEventDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("personScoutingEvent");
            resolver = ResolveConflictFavourClient;
        }

        public override PersonScoutingEvent Convert(IPersonScoutingEvent z)
        {
            return (PersonScoutingEvent)z;
        }

        public override IPersonScoutingEvent Convert(PersonScoutingEvent z)
        {
            return z;
        }
    }
}