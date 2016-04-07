using System;

using System.Collections.Generic;
using Carrick.DataModel;

namespace Scout.BusinessLogic.BusinessLogic
{
    public class ResidenceBusinessLogic : BusinessLogicBase<Residence>
    {
        internal ResidenceBusinessLogic(BusinessLogic BL) : base(BL)
        {
        }

        public IEnumerable<Residence> GetResidences(Person s)
        {
            throw new NotImplementedException();
        }
    }
}