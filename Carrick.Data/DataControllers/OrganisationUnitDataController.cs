namespace Carrick.Data.Controllers
{
    using Carrick.Data.Model;
    public class OrganisationUnitDataController : GenericDataController<OrganisationUnit>
    {
        internal OrganisationUnitDataController(Repository r) : base(r, r.DataModel.OrganisationUnits)
        {
        }

        protected internal override OrganisationUnit TransferSpecificProperties(OrganisationUnit original, ref OrganisationUnit destination, Authorisation<OrganisationUnit> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = new OrganisationUnit(); }

            destination.ParentOrganisationUnitId = original.ParentOrganisationUnitId;
            destination.ParentOrganisationUnitGuid = original.ParentOrganisationUnitGuid;
            destination.Description = original.Description;

            return destination;
        }
    }
}