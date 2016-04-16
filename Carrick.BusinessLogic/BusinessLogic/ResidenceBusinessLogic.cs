using System;

using System.Collections.Generic;
using Carrick.BusinessLogic.Interfaces;

namespace Carrick.BusinessLogic
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