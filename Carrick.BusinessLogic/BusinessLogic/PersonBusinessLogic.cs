using Carrick.BusinessLogic.CompositeObjects;
using Carrick.BusinessLogic.Interfaces;

using System;
using System.Collections.Generic;

namespace Carrick.BusinessLogic
{
    public class PersonBusinessLogic : BusinessLogicBase<IPerson>
    {
        internal PersonBusinessLogic(BusinessLogic BL) :base (BL)
        {
        }

        public IEnumerable<IPerson> GetPersonsInOrganisation(IOrganisationUnit org)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPersonScoutingEvent> GetPersonsAtEvent(IScoutingEvent itm)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPerson> GetParents(IPerson s)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPerson> GetParents()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IPerson> GetActiveScouts()
        {
            throw new NotImplementedException();
        }

        public string GetScoutsSignedIn()
        {
            throw new NotImplementedException();
        }

        public IPerson GetPerson(IPersonBadge itm)
        {
            throw new NotImplementedException();
        }

        public IPerson GetPerson(int id)
        {
            IRelationshipKey key = DataProvider.CreateRelationshipKey();
            key.Id = id;
            return DataProvider.GetItem(key);
        }

        public bool IsSignedIn(IPerson person)
        {
            throw new NotImplementedException();
        }

        public void SignedIn(IPerson person, bool Value)
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
