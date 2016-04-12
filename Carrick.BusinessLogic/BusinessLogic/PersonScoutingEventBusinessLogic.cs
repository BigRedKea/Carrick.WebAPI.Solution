using System;

using System.Collections.Generic;
using Carrick.BusinessLogic.CompositeObjects;
using Carrick.BusinessLogic.Interfaces;

namespace Carrick.BusinessLogic.BusinessLogic
{
    public class PersonScoutingEventBusinessLogic: BusinessLogicBase<IPersonScoutingEvent>
    {
        internal PersonScoutingEventBusinessLogic(BusinessLogic BL) : base(BL)
        {
        }

        public IEnumerable<PersonScoutingEventComposite> GetActiveCompositeItems()
        {
            throw new NotImplementedException();
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
            UnLink(p.PersonScoutingEvent);
        }

        public void UnLink(IPersonScoutingEvent p)
        {
            throw new NotImplementedException();
        }

        public void Link(IScoutingEvent _se, IPerson _Person)
        {
            throw new NotImplementedException();
        }
    }
}