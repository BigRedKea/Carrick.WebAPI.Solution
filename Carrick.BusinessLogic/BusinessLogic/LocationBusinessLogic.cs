
using System;

using Carrick.BusinessLogic.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Carrick.BusinessLogic
{
    public class EventLocationBusinessLogic :BusinessLogicBase <IEventLocation>
    {

        internal EventLocationBusinessLogic(BusinessLogic BL) :base (BL)
        {

        }


        public IEnumerable<IEventLocation> SearchActiveItems(string searchText, int Limit)
        {
            searchText = searchText ?? "";

            IEnumerable<IEventLocation> p = GetActiveItems()
                    .Take(Limit);

            return p;
        }






    }
}