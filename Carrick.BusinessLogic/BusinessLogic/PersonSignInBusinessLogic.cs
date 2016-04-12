using Carrick.BusinessLogic.Interfaces;
using System;


namespace Carrick.BusinessLogic.BusinessLogic
{
    public class PersonSignInBusinessLogic : BusinessLogicBase<IPersonSignIn>
    {
        internal PersonSignInBusinessLogic(BusinessLogic BL) : base(BL)
        {
        }      
    }
}