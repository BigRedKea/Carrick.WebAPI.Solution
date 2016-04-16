namespace Carrick.ServerData.Controllers
{
    using Carrick.BusinessLogic.Interfaces;
    using Carrick.Web.Models;

    public class OrganisationUnitDataProvider : GenericDataProvider<IOrganisationUnit, OrganisationUnit>
    {
        internal OrganisationUnitDataProvider(Repository r) : base(r, r.DataModel.OrganisationUnits)
        {
        }

        protected internal override IOrganisationUnit TransferSpecificProperties(IOrganisationUnit original, ref OrganisationUnit destination, Authorisation<IOrganisationUnit> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = Convert(CreateItem()); }

            destination.ParentOrganisationUnitId = original.ParentOrganisationUnitId;
            destination.ParentOrganisationUnitGuid = original.ParentOrganisationUnitGuid;
            destination.Description = original.Description;

            return destination;
        }

        public override OrganisationUnit Convert(IOrganisationUnit z)
        {
            return (OrganisationUnit)z;
        }

        public override IOrganisationUnit Convert(OrganisationUnit z)
        {
            return z;
        }
    }
}