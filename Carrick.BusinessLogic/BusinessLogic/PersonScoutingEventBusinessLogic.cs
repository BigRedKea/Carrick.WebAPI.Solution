using System;

using System.Collections.Generic;
using Carrick.BusinessLogic.CompositeObjects;
using Carrick.DataModel;

namespace Carrick.BusinessLogic.BusinessLogic
{
    public class PersonScoutingEventBusinessLogic: BusinessLogicBase<PersonScoutingEvent>
    {
        internal PersonScoutingEventBusinessLogic(BusinessLogic BL) : base(BL)
        {
        }

        public IEnumerable<PersonScoutingEventComposite> GetActiveCompositeItems()
        {
            throw new NotImplementedException();
        }

        public IEnumerable <PersonScoutingEventComposite> GetItemsForEvent(ScoutingEvent _Event)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonScoutingEventComposite> GetItemsForPerson(Person p)
        {
            throw new NotImplementedException();
        }

        public void UnLink(PersonScoutingEventComposite p)
        {
            UnLink(p.PersonScoutingEvent);
        }

        public void UnLink(PersonScoutingEvent p)
        {
            throw new NotImplementedException();
        }

        public void Link(ScoutingEvent _se, Person _Person)
        {
            throw new NotImplementedException();
        }
    }
}