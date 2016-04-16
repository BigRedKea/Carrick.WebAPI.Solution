
using System;

using Carrick.BusinessLogic.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Carrick.BusinessLogic
{
    public class BadgeBusinessLogic :BusinessLogicBase <IBadge>
    {

        internal BadgeBusinessLogic(BusinessLogic BL) :base (BL)
        {

        }

        public IBadge GetBadge(IPersonBadge br)
        {
            if (br != null)
            {
                return null;
            }
            else if (br.BadgeId != null)
            {
                return null;
            }
            else
            { 
                return GetItem(br.BadgeId.Value);
            }
        }


        public IEnumerable<IBadge> SearchActiveItems(string searchText, int Limit)
        {
            searchText = searchText ?? "";

            IEnumerable<IBadge> p = GetActiveItems()
                    .Where(x => x.BadgeEnabled.HasValue == true)
                    .Where(x => x.BadgeEnabled.Value == true)
                    .Where(x => x.BadgeName.Contains(searchText) || x.BadgeLevel.Contains(searchText))
                    .OrderBy(DataProvider.defaultOrder)
                    .Take(Limit);

            return p;
        }

        public IEnumerable<IBadge> GetActiveEnabledItems()
        {

            IEnumerable<IBadge> p = GetActiveItems()
                    .Where(x => x.BadgeEnabled.HasValue == true)
                    .Where(x => x.BadgeEnabled.Value == true)
                    .OrderBy(DataProvider.defaultOrder);
            return p;
        }

    }
}