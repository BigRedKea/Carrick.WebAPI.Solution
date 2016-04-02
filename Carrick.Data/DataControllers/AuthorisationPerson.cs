

namespace Carrick.Data.Controllers
{
    using System;
    using Carrick.Data.Model;

    public class AuthorisationPerson : Authorisation<Person>
    {
        internal AuthorisationPerson(Guid? PersonRequestingAccessKey, bool ReadRequested = false, bool WriteRequested = false, bool DeleteRequested = false)
            :base(PersonRequestingAccessKey, ReadRequested , WriteRequested, DeleteRequested)
        {

        }

        public bool CanAccessDateOfBirth(Person p)
        {
            bool retval = false;
            if (!retval && IsMe(p))
            {retval = WriteRequested || ReadRequested; }

            if (!retval && IsParentOf(p))
            { retval = WriteRequested || ReadRequested; }

            if (!retval && IsAdultLeaderOf(p))
            { retval = WriteRequested || ReadRequested; }

            return retval;
        }

        public bool CanAccessMedical(Person p)
        {
            bool retval = false;
            if (!retval && IsMe(p))
            { retval = WriteRequested || ReadRequested; }

            if (!retval && IsParentOf(p))
            { retval = WriteRequested || ReadRequested; }

            if (!retval && IsAdultLeaderOf(p))
            { retval = WriteRequested || ReadRequested; }

            return retval;
        }

        public bool CanAccessMembership(Person p)
        {
            bool retval = false;
            if (!retval && IsMe(p) && !WriteRequested)
            { retval = ReadRequested; }

            if (!retval && IsParentOf(p))
            { retval = ReadRequested; }

            if (!retval && IsAdultLeaderOf(p))
            { retval = WriteRequested || ReadRequested; }

            return retval;
        }

        public bool CanAccessContactInfo(Person p)
        {
            bool retval = false;

            if (!retval && IsMe(p))
            { retval = WriteRequested || ReadRequested; }

            if (!retval && IsParentOf(p))
            { retval = WriteRequested || ReadRequested; }

            if (!retval && IsAdultLeaderOf(p))
            { retval = WriteRequested || ReadRequested; }

            return retval;
        }
    }
}
