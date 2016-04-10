namespace Carrick.ServerData.Controllers
{
    using Carrick.DataModel;
    public class PersonOrganisationUnitDataProvider : GenericDataProvider<PersonOrganisationUnit>
    {
        internal PersonOrganisationUnitDataProvider(Repository r) : base(r, r.DataModel.PersonOrganisationUnits)
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
