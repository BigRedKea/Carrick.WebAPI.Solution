using System;
using Carrick.DataModel;


namespace Scout.BusinessLogic.BusinessLogic
{
    public class PersonPersonBusinessLogic : BusinessLogicBase<PersonPerson>
    {
        internal PersonPersonBusinessLogic(BusinessLogic BL) : base(BL)
        {
        }

        public void LinkScoutParent(Person _Scout, Person _ScoutParent)
        {
            throw new NotImplementedException();
        }

        public void BreakParentScoutLink(Person scout, Person _ScoutParent)
        {
            throw new NotImplementedException();
        }
    }
}