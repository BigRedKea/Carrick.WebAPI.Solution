namespace Carrick.ServerData.Controllers
{

    using Carrick.BusinessLogic.Interfaces;
    using Carrick.Web.Models;

    public class PersonOrganisationUnitDataProvider : GenericDataProvider<IPersonOrganisationUnit, PersonOrganisationUnit >
    {
        internal PersonOrganisationUnitDataProvider(Repository r) : base(r, r.DataModel.PersonOrganisationUnits)
        {
        }

        protected internal override IPersonOrganisationUnit TransferSpecificProperties(IPersonOrganisationUnit original, ref PersonOrganisationUnit destination, Authorisation<IPersonOrganisationUnit> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = Convert(CreateItem()); }

            destination.PersonId = original.PersonId;
            destination.PersonGuid = original.PersonGuid;
            destination.OrganisationUnitId = original.OrganisationUnitId;
            destination.OrganisationUnitGuid = original.OrganisationUnitGuid;
            return destination;
        }


        public override PersonOrganisationUnit Convert(IPersonOrganisationUnit z)
        {
            return (PersonOrganisationUnit)z;
        }

        public override IPersonOrganisationUnit Convert(PersonOrganisationUnit z)
        {
            return z;
        }
    }
}
