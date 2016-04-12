namespace Carrick.ServerData.Controllers
{
    using BusinessLogic.Interfaces;
    using Carrick.Server.DataModel;

    public class PersonOrganisationUnitDataProvider : GenericDataProvider<IPersonOrganisationUnit, PersonOrganisationUnit >
    {
        internal PersonOrganisationUnitDataProvider(Repository r) : base(r, r.DataModel.PersonOrganisationUnits)
        {
        }

        protected internal override IPersonOrganisationUnit TransferSpecificProperties(IPersonOrganisationUnit original, ref IPersonOrganisationUnit destination, Authorisation<IPersonOrganisationUnit> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = new PersonOrganisationUnit(); }

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
