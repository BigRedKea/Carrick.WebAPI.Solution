
using System;
using Carrick.BusinessLogic.Interfaces;

namespace Carrick.BusinessLogic.CompositeObjects
{
    public class PersonComposite
    {
        public IPerson Person { get; set; }
        public IOrganisationUnit Organisation { get; set; }

        public TimeSpan? Age()
        {
            if (Person.DateOfBirth.HasValue)
            {
                return DateTime.Now - Person.DateOfBirth.Value;
            }
            else
            {
                return null;
            }   
        }

        public override string ToString()
        {
            return Person.PreferredName + " " + Person.Surname;
        }

        string FullName()
        {
            return Person.PreferredName + " " + Person.Surname;
        }


       IOrganisationUnit Patrol()
        {
            throw new NotImplementedException();
        }

        public TimeSpan? LengthOfService()
        {
            if (Person.DateOfInvestiture.HasValue)
            {
                return DateTime.Now - Person.DateOfInvestiture.Value;
            }
            else
            {
                return null;
            }
        }

        public DateTime LastSignedIn()
        {
            throw new NotImplementedException();
        }

        public Boolean IsBirthday()
        {
            if (Person.DateOfBirth.HasValue)
            {
                if ((Person.DateOfBirth.Value.Month == DateTime.Now.Month) && (Person.DateOfBirth.Value.Day == DateTime.Now.Day))
                {
                    return true;
                }
            }
            return false;
        }

        public string ScoutNights()
        {
            throw new NotImplementedException();
        }

        public IPersonSignIn GetLatestSignIn(IPerson p)
        {
            throw new NotImplementedException();
        }

        public void SignIn(IPerson p)
        {
            EventArgs e = new EventArgs();
            PersonSignedInEventHandler handler = PersonSignedInEvent;
            if (handler != null)
            {
                handler(p, e);
            }
        }

        public void SignOut(IPerson p)
        {
            EventArgs e = new EventArgs();
            PersonSignedOutEventHandler handler = PersonSignedOutEvent;
            if (handler != null)
            {
                handler(p, e);
            }
            handler.Invoke(p, e);
        }

        public delegate void PersonSignedInEventHandler(object x, EventArgs e);
        public delegate void PersonSignedOutEventHandler(object x, EventArgs e);

        public event PersonSignedInEventHandler PersonSignedInEvent;
        public event PersonSignedOutEventHandler PersonSignedOutEvent;
        //HACK public event PropertyChangedEventHandler PropertyChangedEvent;
    }
}
