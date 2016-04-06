namespace ScoutDataModelPortable.DataProviders
{
    using System;
    using ScoutDataModelPortable.Model;
    using Scout.BusinessLogic.Interfaces;

    public class PersonScoutingEventDataProvider : DataProviderBase<IPersonScoutingEvent, PersonScoutingEvent>
    {
        public PersonScoutingEventDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/personScoutingEvent");
            resolver = ResolveConflictFavourClient;
        }

        protected override IPersonScoutingEvent InternalFactory()
        {
            IPersonScoutingEvent r = new PersonScoutingEvent();
            return r;
        }

        protected override IPersonScoutingEvent Convert(PersonScoutingEvent item)
        {
            return item;
        }
    }
}