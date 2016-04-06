using System;
using Scout.BusinessLogic.Interfaces;
using System.Collections.Generic;
using Scout.BusinessLogic.CompositeObjects;

namespace Scout.BusinessLogic.BusinessLogic
{
    public class PersonScoutingEventBusinessLogic: BusinessLogicBase<IPersonScoutingEvent>
    {
        internal PersonScoutingEventBusinessLogic(BusinessLogic BL) : base(BL)
        {
        }

        public IEnumerable <PersonScoutingEventComposite> GetItemsForEvent(IScoutingEvent _Event)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonScoutingEventComposite> GetItemsForPerson(IPerson p)
        {
            throw new NotImplementedException();
        }

        public void UnLink(PersonScoutingEventComposite p)
        {
            throw new NotImplementedException();
        }

        public void Link(IScoutingEvent _se, IPerson _Person)
        {
            throw new NotImplementedException();
        }
    }
}