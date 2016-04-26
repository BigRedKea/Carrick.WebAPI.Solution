
using System;

using Carrick.BusinessLogic.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Carrick.BusinessLogic
{
    public class LocationBusinessLogic :BusinessLogicBase <ILocation>
    {

        internal LocationBusinessLogic(BusinessLogic BL) :base (BL)
        {

        }

        public IEnumerable<ILocation> SearchActiveItems(string searchText, int Limit)
        {
            searchText = searchText ?? "";

            IEnumerable<ILocation> p = GetActiveItems()
                    .Take(Limit);

            return p;
        }


    }
}