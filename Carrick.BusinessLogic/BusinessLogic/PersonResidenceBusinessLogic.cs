using System;
using Carrick.DataModel;

namespace Carrick.BusinessLogic.BusinessLogic
{
    public class PersonResidenceBusinessLogic : BusinessLogicBase<PersonResidence>
    {
        internal PersonResidenceBusinessLogic(BusinessLogic BL) : base(BL)
        {
        }

        public void LinkPersonResidence(Person _Person, Residence r)
        {
            throw new NotImplementedException();
        }

        public void UpdatePersonResidence(Person _Person, int id, Residence r)
        {
            throw new NotImplementedException();
        }
    }

}