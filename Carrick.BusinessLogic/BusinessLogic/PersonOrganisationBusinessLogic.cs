using System;


namespace Carrick.BusinessLogic.BusinessLogic
{

    using Carrick.DataModel;

    public class PersonOrganisationUnitBusinessLogic: BusinessLogicBase<PersonOrganisationUnit>
    {
        internal PersonOrganisationUnitBusinessLogic(BusinessLogic BL) :base (BL)
        {
        }

        public void ChangeOrganisation(Person _Scout, OrganisationUnit selectedItem)
        {
            throw new NotImplementedException();
        }
    }
}