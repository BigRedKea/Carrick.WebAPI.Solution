namespace Carrick.Data.Controllers
{
    using Carrick.DataModel;
    using System.Linq;
    using System;
    using System.Collections.Generic;
    public class PersonDataProvider : GenericDataProvider<Person>
    {
        internal PersonDataProvider(Repository r) : base(r, r.DataModel.People)
        {
            try
            {
                if(r.PersonRequestingAccess== null )
                {
                    AuthorisationGet = new AuthorisationPerson(null, false, false);
                    AuthorisationUpdate = new AuthorisationPerson(null, false, false);
                }
                else
                {
                    AuthorisationGet = new AuthorisationPerson(r.PersonRequestingAccess.RowGuid, true, false);
                    AuthorisationUpdate = new AuthorisationPerson(r.PersonRequestingAccess.RowGuid, true, true);
                }

            }
            catch (Exception ex)
            {
                throw new Exception("Failed to Initialise PersonDataController", ex);
            }
        }

        protected internal override Person TransferSpecificProperties( Person original, ref Person destination, Authorisation<Person> Authorisation)
        {
            AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) destination = new Person();

            destination.PreferredName = original.PreferredName;
            destination.Surname = original.Surname;


            if (ap.CanAccessDateOfBirth(original))
            {
                destination.DateOfBirth = original.DateOfBirth;
            }

            destination.DateOfInvestiture = original.DateOfInvestiture;

            if (ap.CanAccessMedical(original))
            {
                destination.MedicareNumber = original.MedicareNumber;
                destination.LastTetanus = original.LastTetanus;
            }

            if (ap.CanAccessMembership(original))
            {
                destination.MembershipId = original.MembershipId;
                destination.DateLeftOrganisation = original.DateLeftOrganisation;
                destination.NotesForMembership = original.NotesForMembership;
                destination.FamilyCode = original.FamilyCode;
            }

            if (ap.CanAccessContactInfo(original))
            {
                destination.Email = original.Email;
                destination.Mobile = original.Mobile;
            }
            destination.Gender = original.Gender;
            return destination;
        }

        public override IEnumerable<Person> GetActiveItems()
        {
            return base.GetActiveItems().Where(x => (x.IsDeleted == false)
                    && (x.DateLeftOrganisation == null));
        }

        public IEnumerable<Person> GetChildren(Person p)
        {
            return Repository.PersonPersonDataController.GetRelatedAPersons(p, 1);
        }

        public IEnumerable<Person> GetParents(Person p)
        {
            return Repository.PersonPersonDataController.GetRelatedBPersons(p, 1);
        }

    }
}
