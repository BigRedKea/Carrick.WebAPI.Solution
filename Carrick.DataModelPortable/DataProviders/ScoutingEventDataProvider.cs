namespace ScoutDataModelPortable.DataProviders
{
    using System;
    using ScoutDataModelPortable.Model;
    using Scout.BusinessLogic.Interfaces;

    public class ScoutingEventDataProvider : DataProviderBase<IScoutingEvent, ScoutingEvent>
    {
        public ScoutingEventDataProvider(ModelDataProvider modelDataProvider) : base(modelDataProvider)
        {
            CreateWebAPIHelper("/api/ScoutingEvent");
            resolver = ResolveConflictFavourClient;
        }

        protected override IScoutingEvent InternalFactory()
        {
            IScoutingEvent r = new ScoutingEvent();
            return r;
        }

        protected override IScoutingEvent Convert(ScoutingEvent item)
        {
            return item;
        }
    }
}