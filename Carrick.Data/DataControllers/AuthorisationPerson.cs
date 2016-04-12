

namespace Carrick.ServerData.Controllers
{
    using System;
    using Carrick.Server.DataModel;
    using BusinessLogic.Interfaces;
    public class AuthorisationPerson : Authorisation<IPerson>
    {
        internal AuthorisationPerson(Guid? PersonRequestingAccessKey, bool ReadRequested = false, bool WriteRequested = false, bool DeleteRequested = false)
            :base(PersonRequestingAccessKey, ReadRequested , WriteRequested, DeleteRequested)
        {

        }
        
        public bool CanAccessDateOfBirth(IPerson p)
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

        public bool CanAccessMedical(IPerson p)
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

        public bool CanAccessMembership(IPerson p)
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

        public bool CanAccessContactInfo(IPerson p)
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
