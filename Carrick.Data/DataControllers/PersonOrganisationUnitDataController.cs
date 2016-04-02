namespace Carrick.Data.Controllers
{
    using Carrick.Data.Model;
    public class PersonOrganisationUnitDataController : GenericDataController<PersonOrganisationUnit>
    {
        internal PersonOrganisationUnitDataController(Repository r) : base(r, r.DataModel.PersonOrganisationUnits)
        {
        }

        protected internal override PersonOrganisationUnit TransferSpecificProperties(PersonOrganisationUnit original, ref PersonOrganisationUnit destination, Authorisation<PersonOrganisationUnit> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = new PersonOrganisationUnit(); }

            destination.PersonId = original.PersonId;
            destination.PersonGuid = original.PersonGuid;
            destination.OrganisationUnitId = original.OrganisationUnitId;
            destination.OrganisationUnitGuid = original.OrganisationUnitGuid;
            return destination;
        }
    }
}
