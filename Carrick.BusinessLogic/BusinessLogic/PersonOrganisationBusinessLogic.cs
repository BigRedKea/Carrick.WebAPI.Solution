using Carrick.BusinessLogic.Interfaces;
using System;


namespace Carrick.BusinessLogic.BusinessLogic
{


    public class PersonOrganisationUnitBusinessLogic: BusinessLogicBase<IPersonOrganisationUnit>
    {
        internal PersonOrganisationUnitBusinessLogic(BusinessLogic BL) :base (BL)
        {
        }

        public void ChangeOrganisation(IPerson _Scout, IOrganisationUnit selectedItem)
        {
            throw new NotImplementedException();
        }
    }
}