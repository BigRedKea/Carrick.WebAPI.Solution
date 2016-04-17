using System;

using System.Collections.Generic;
using Carrick.BusinessLogic.CompositeObjects;
using Carrick.BusinessLogic.Interfaces;
using System.Linq;

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

        public IEnumerable<IScoutingEvent> GetFutureItems()
        { 
            return DataProvider.GetActiveItems().Where(x => x.StartDateTime > DateTime.Now);
        }

        public IScoutingEvent GetScoutingEvent(PersonScoutingEventComposite p)
        {
            throw new NotImplementedException();
        }


    }
}