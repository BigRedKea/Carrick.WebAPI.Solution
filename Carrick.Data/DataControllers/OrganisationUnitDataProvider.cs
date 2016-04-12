namespace Carrick.ServerData.Controllers
{
    using BusinessLogic.Interfaces;
    using Carrick.Server.DataModel;

    public class OrganisationUnitDataProvider : GenericDataProvider<IOrganisationUnit, OrganisationUnit>
    {
        internal OrganisationUnitDataProvider(Repository r) : base(r, r.DataModel.OrganisationUnits)
        {
        }

        protected internal override IOrganisationUnit TransferSpecificProperties(IOrganisationUnit original, ref IOrganisationUnit destination, Authorisation<IOrganisationUnit> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = new OrganisationUnit(); }

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