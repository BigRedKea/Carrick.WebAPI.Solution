﻿using System;
using Scout.BusinessLogic.Interfaces;

namespace Scout.BusinessLogic.BusinessLogic
{
    public class PersonResidenceBusinessLogic : BusinessLogicBase<IPersonResidence>
    {
        internal PersonResidenceBusinessLogic(BusinessLogic BL) : base(BL)
        {
        }

        public void LinkPersonResidence(IPerson _Person, IResidence r)
        {
            throw new NotImplementedException();
        }

        public void UpdatePersonResidence(IPerson _Person, int id, IResidence r)
        {
            throw new NotImplementedException();
        }
    }

}