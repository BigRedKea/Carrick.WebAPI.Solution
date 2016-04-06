using System;
using Scout.BusinessLogic.Interfaces;

namespace Scout.BusinessLogic.BusinessLogic
{
    public class PersonScoutingRoleBusinessLogic : BusinessLogicBase<IPersonScoutingRole>
    {
        internal PersonScoutingRoleBusinessLogic(BusinessLogic BL) : base(BL)
        {
        }
    }
}