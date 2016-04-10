namespace Carrick.ServerData.Controllers
{
    using Carrick.DataModel;
    public class OrganisationUnitDataProvider : GenericDataProvider<OrganisationUnit>
    {
        internal OrganisationUnitDataProvider(Repository r) : base(r, r.DataModel.OrganisationUnits)
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