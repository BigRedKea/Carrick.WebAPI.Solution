using System;
using Scout.BusinessLogic.Interfaces;

namespace Scout.BusinessLogic.BusinessLogic
{
    public class PersonSignInBusinessLogic : BusinessLogicBase<IPersonSignIn>
    {
        internal PersonSignInBusinessLogic(BusinessLogic BL) : base(BL)
        {
        }


        
    }
}