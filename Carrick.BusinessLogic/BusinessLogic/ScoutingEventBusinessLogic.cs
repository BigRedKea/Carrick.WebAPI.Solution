using System;

using System.Collections.Generic;
using Scout.BusinessLogic.CompositeObjects;
using Carrick.DataModel;

namespace Scout.BusinessLogic.BusinessLogic
{
    public class ScoutingEventBusinessLogic : BusinessLogicBase<ScoutingEvent>
    {
        internal ScoutingEventBusinessLogic(BusinessLogic BL) : base(BL)
        {
        }

        public IEnumerable<PersonScoutingEventComposite> GetScoutingEvents(Person p)
        {
            throw new NotImplementedException();
        }

        public ScoutingEvent GetScoutingEvent(PersonScoutingEventComposite p)
        {
            throw new NotImplementedException();
        }
    }
}