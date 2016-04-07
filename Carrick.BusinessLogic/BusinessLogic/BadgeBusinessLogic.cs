
using System;
using Carrick.DataModel;

namespace Scout.BusinessLogic.BusinessLogic
{
    public class BadgeBusinessLogic :BusinessLogicBase <Badge>
    {

        internal BadgeBusinessLogic(BusinessLogic BL) :base (BL)
        {

        }

        public Badge GetBadge(PersonBadge br)
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