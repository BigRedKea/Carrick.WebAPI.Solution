namespace Carrick.ServerData.Controllers
{
    using Carrick.DataModel;

    public class PersonResidenceDataProvider : GenericDataProvider<PersonResidence>
    {

        internal PersonResidenceDataProvider(Repository r) : base(r, r.DataModel.PersonResidences)
        {
        }

        protected internal override PersonResidence TransferSpecificProperties(PersonResidence original,ref PersonResidence destination, Authorisation<PersonResidence> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = new PersonResidence(); }
            destination.PersonId = original.PersonId;
            destination.PersonGuid = original.PersonGuid;
            destination.ResidenceId = original.ResidenceId;
            destination.ResidenceGuid = original.ResidenceGuid;
            return destination;
        }
    }
}
