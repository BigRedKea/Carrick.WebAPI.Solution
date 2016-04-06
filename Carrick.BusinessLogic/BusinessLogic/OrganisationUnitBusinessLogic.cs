namespace Scout.BusinessLogic.BusinessLogic
{
    using System;
    using Scout.BusinessLogic.Interfaces;
    using System.Collections;
    using System.Collections.Generic;
    public class OrganisationUnitBusinessLogic : BusinessLogicBase<IPerson>
    {
        internal OrganisationUnitBusinessLogic(BusinessLogic BL) :base (BL)
        {
        }

        public object GetOrganisations(IPerson s)
        {
            throw new NotImplementedException();
        }

        public List<IOrganisationUnit> GetOrganisationsSortedLargestToSmallest()
        {
            throw new NotImplementedException();
        }


        public delegate void PersonAddedHandler(OrganisationUnitBusinessLogic sender, PersonAddedEventArgs e);
        public event PersonAddedHandler PersonAddedEvent;

        public void PersonAdd(IOrganisationUnit org, IPerson p)
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

        public void PersonRemove(IOrganisationUnit org, IPerson p)
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
        public PersonAddedEventArgs(IOrganisationUnit org, IPerson p)
        {
            OrganisationUnit = org;
            Person = p;
        }

        public IOrganisationUnit OrganisationUnit { get; set; }
        public IPerson Person { get; set; }
    }

    public class PersonRemovedEventArgs
    {
        public PersonRemovedEventArgs(IOrganisationUnit org, IPerson p)
        {
            OrganisationUnit = org;
            Person = p;
        }

        public IOrganisationUnit OrganisationUnit { get; set; }
        public IPerson Person { get; set; }
    }
}