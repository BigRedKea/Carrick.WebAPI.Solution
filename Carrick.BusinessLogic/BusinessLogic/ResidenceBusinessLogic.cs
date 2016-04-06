using System;
using Scout.BusinessLogic.Interfaces;
using System.Collections.Generic;

namespace Scout.BusinessLogic.BusinessLogic
{
    public class ResidenceBusinessLogic : BusinessLogicBase<IResidence>
    {
        internal ResidenceBusinessLogic(BusinessLogic BL) : base(BL)
        {
        }

        public IEnumerable<IResidence> GetResidences(IPerson s)
        {
            throw new NotImplementedException();
        }
    }
}