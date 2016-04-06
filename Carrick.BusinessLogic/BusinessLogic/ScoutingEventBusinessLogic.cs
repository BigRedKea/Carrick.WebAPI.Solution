using System;
using Scout.BusinessLogic.Interfaces;
using System.Collections.Generic;
using Scout.BusinessLogic.CompositeObjects;

namespace Scout.BusinessLogic.BusinessLogic
{
    public class ScoutingEventBusinessLogic : BusinessLogicBase<IScoutingEvent>
    {
        internal ScoutingEventBusinessLogic(BusinessLogic BL) : base(BL)
        {
        }

        public IEnumerable<PersonScoutingEventComposite> GetScoutingEvents(IPerson p)
        {
            throw new NotImplementedException();
        }

        public IScoutingEvent GetScoutingEvent(PersonScoutingEventComposite p)
        {
            throw new NotImplementedException();
        }
    }
}