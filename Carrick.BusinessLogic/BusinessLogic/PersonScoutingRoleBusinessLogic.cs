using System;

using Carrick.BusinessLogic.Interfaces;

namespace Carrick.BusinessLogic.BusinessLogic
{
    public class PersonScoutingRoleBusinessLogic : BusinessLogicBase<IPersonScoutingRole>
    {
        internal PersonScoutingRoleBusinessLogic(BusinessLogic BL) : base(BL)
        {
        }
    }
}