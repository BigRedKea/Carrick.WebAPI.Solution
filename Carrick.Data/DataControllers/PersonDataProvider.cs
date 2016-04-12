namespace Carrick.ServerData.Controllers
{

    using System.Linq;
    using System;
    using System.Collections.Generic;
    using Carrick.Server.DataModel;
    using BusinessLogic.Interfaces;
    public class PersonDataProvider : GenericDataProvider<IPerson, Person>
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

        protected internal override IPerson TransferSpecificProperties(IPerson original, ref IPerson destination, Authorisation<IPerson> Authorisation)
        {
            AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) destination = CreateItem();

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

        public override IEnumerable<IPerson> GetActiveItems()
        {
            return base.GetActiveItems().Where(x => (x.IsDeleted == false)
                    && (x.DateLeftOrganisation == null));
        }

        public IEnumerable<IPerson> GetChildren(IPerson p)
        {
            return Repository.PersonPersonDataController.GetRelatedAPersons(p, 1);
        }

        public IEnumerable<IPerson> GetParents(IPerson p)
        {
            return Repository.PersonPersonDataController.GetRelatedBPersons(p, 1);
        }


        public override Person Convert(IPerson z)
        {
            return (Person)z;
        }

        public override IPerson Convert(Person z)
        {
            return z;
        }
    }
}
