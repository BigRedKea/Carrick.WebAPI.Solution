using System;

using System.Collections.Generic;
using Carrick.BusinessLogic.CompositeObjects;
using Carrick.BusinessLogic.Interfaces;

namespace Carrick.BusinessLogic
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