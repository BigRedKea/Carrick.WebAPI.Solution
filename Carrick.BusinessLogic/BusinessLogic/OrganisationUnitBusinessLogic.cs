namespace Carrick.BusinessLogic
{
    using Interfaces;
    using System;

    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    public class OrganisationUnitBusinessLogic : BusinessLogicBase<IOrganisationUnit>
    {
        internal OrganisationUnitBusinessLogic(BusinessLogic BL) :base (BL)
        {
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

        internal IEnumerable<IOrganisationUnit> GetOrganisationUnits(IPerson s)
        {
            var keys = new List<IRelationshipKey>();
            var retval = new List<IOrganisationUnit>();

            foreach (var z in _BL.PersonOrganisationUnitBL.GetPersonOrganisationUnits(s))
            {
                if (!keys.Contains(z.PersonKey()))
                    {
                    keys.Add(z.OrganisationUnitKey());
                }             
            }

            foreach (var itm in GetActiveItems())
            {
                foreach (var key in keys)
                {
                    if (key.Matches(itm.PrimaryKey()))
                    {
                        retval.Add(itm);
                    }
                }                 
            }

            return retval;
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