
using System;

using Carrick.BusinessLogic.Interfaces;

namespace Carrick.BusinessLogic.BusinessLogic
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

    }
}