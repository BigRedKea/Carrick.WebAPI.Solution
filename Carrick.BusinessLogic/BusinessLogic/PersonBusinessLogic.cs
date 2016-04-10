using Carrick.BusinessLogic.CompositeObjects;
using Carrick.DataModel;
using System;
using System.Collections.Generic;

namespace Carrick.BusinessLogic.BusinessLogic
{
    public class PersonBusinessLogic : BusinessLogicBase<Person>
    {
        internal PersonBusinessLogic(BusinessLogic BL) :base (BL)
        {
        }

        public IEnumerable<Person> GetPersonsInOrganisation(OrganisationUnit org)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonScoutingEvent> GetPersonsAtEvent(ScoutingEvent itm)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetParents(Person s)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetParents()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetActiveScouts()
        {
            throw new NotImplementedException();
        }

        public string GetScoutsSignedIn()
        {
            throw new NotImplementedException();
        }

        public Person GetPerson(PersonBadge itm)
        {
            throw new NotImplementedException();
        }

        public bool IsSignedIn(Person person)
        {
            throw new NotImplementedException();
        }

        public void SignedIn(Person person, bool Value)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PersonComposite> GetAllScouts()
        {
            throw new NotImplementedException();
        }

        public delegate void PersonSignedInHandler(PersonBusinessLogic sender, PersonSignedInEventArgs e);
        public event PersonSignedInHandler PersonSignedInEvent;

        public void PersonSignedIn()
        {
            PersonSignedInEventArgs e =  new PersonSignedInEventArgs();

            // if anyone has subscribed, notify them
            if (PersonSignedInEvent != null)
            {
                PersonSignedInEvent(this, e);
            }
        }

        public delegate void PersonSignedOutHandler(PersonBusinessLogic sender, PersonSignedOutEventArgs e);
        public event PersonSignedOutHandler PersonSignedOutEvent;

        public void PersonSignedOut()
        {
            PersonSignedOutEventArgs e = new PersonSignedOutEventArgs();

            // if anyone has subscribed, notify them
            if (PersonSignedOutEvent != null)
            {
                PersonSignedOutEvent(this, e);
            }
        }


    }


    public class PersonSignedInEventArgs :EventArgs
    {
    }

    public class PersonSignedOutEventArgs :EventArgs
    {
    }
}
