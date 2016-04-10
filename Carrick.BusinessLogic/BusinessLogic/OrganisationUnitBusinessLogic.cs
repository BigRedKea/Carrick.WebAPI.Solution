namespace Carrick.BusinessLogic.BusinessLogic
{
    using System;
    
    using System.Collections;
    using System.Collections.Generic;
    using Carrick.DataModel;

    public class OrganisationUnitBusinessLogic : BusinessLogicBase<OrganisationUnit>
    {
        internal OrganisationUnitBusinessLogic(BusinessLogic BL) :base (BL)
        {
        }

        public object GetOrganisations(Person s)
        {
            throw new NotImplementedException();
        }

        public List<OrganisationUnit> GetOrganisationsSortedLargestToSmallest()
        {
            throw new NotImplementedException();
        }


        public delegate void PersonAddedHandler(OrganisationUnitBusinessLogic sender, PersonAddedEventArgs e);
        public event PersonAddedHandler PersonAddedEvent;

        public void PersonAdd(OrganisationUnit org, Person p)
        {
            PersonAddedEventArgs e = new PersonAddedEventArgs( org,  p);

            // if anyone has subscribed, notify them
            if (PersonAddedEvent != null)
            {
                PersonAddedEvent(this, e);
            }
        }

        public delegate void PersonRemovedHandler(OrganisationUnitBusinessLogic sender, PersonRemovedEventArgs e);
        public event PersonRemovedHandler PersonRemovedEvent;

        public void PersonRemove(OrganisationUnit org, Person p)
        {
            PersonRemovedEventArgs e = new PersonRemovedEventArgs(org, p);

            // if anyone has subscribed, notify them
            if (PersonRemovedEvent != null)
            {
                PersonRemovedEvent(this, e);
            }
        }
    }

    public class PersonAddedEventArgs
    {
        public PersonAddedEventArgs(OrganisationUnit org, Person p)
        {
            OrganisationUnit = org;
            Person = p;
        }

        public OrganisationUnit OrganisationUnit { get; set; }
        public Person Person { get; set; }
    }

    public class PersonRemovedEventArgs
    {
        public PersonRemovedEventArgs(OrganisationUnit org, Person p)
        {
            OrganisationUnit = org;
            Person = p;
        }

        public OrganisationUnit OrganisationUnit { get; set; }
        public Person Person { get; set; }
    }
}