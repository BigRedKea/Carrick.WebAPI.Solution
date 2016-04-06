using System;
using Scout.BusinessLogic.Interfaces;

namespace Scout.BusinessLogic.BusinessLogic
{
    public class PersonPersonBusinessLogic : BusinessLogicBase<IPersonPerson>
    {
        internal PersonPersonBusinessLogic(BusinessLogic BL) : base(BL)
        {
        }

        public void LinkScoutParent(IPerson _Scout, IPerson _ScoutParent)
        {
            throw new NotImplementedException();
        }

        public void BreakParentScoutLink(IPerson scout, IPerson _ScoutParent)
        {
            throw new NotImplementedException();
        }
    }
}