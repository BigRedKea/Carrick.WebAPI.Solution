using Carrick.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Carrick.BusinessLogic
{


    public class PersonOrganisationUnitBusinessLogic: BusinessLogicBase<IPersonOrganisationUnit>
    {
        internal PersonOrganisationUnitBusinessLogic(BusinessLogic BL) :base (BL)
        {
        }

        public IEnumerable<IPersonOrganisationUnit> GetPersonOrganisationUnits(IPerson s)
        {
            var p = GetActiveItems()
                .Where(x => x.PersonGuid == s.RowGuid);
            return p;  
        }

        public IEnumerable<IPersonOrganisationUnit> GetPersonOrganisationUnits(IOrganisationUnit org)
        {
            var p = GetActiveItems()
                .Where(x => x.OrganisationUnitKey().Matches(org.PrimaryKey()));
            return p;
        }

        public void ChangeOrganisation(IPerson _Scout, IOrganisationUnit selectedItem)
        {
            throw new NotImplementedException();
        }

    }
}