namespace Carrick.ServerData.Controllers
{
    using Carrick.BusinessLogic.Interfaces;
    using Carrick.Web.Models;

    public class PersonResidenceDataProvider : GenericDataProvider<IPersonResidence, PersonResidence>
    {

        internal PersonResidenceDataProvider(Repository r) : base(r, r.DataModel.PersonResidences)
        {
        }

        protected internal override IPersonResidence TransferSpecificProperties(IPersonResidence original,ref PersonResidence destination, Authorisation<IPersonResidence> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { Convert(CreateItem()); }
            destination.PersonId = original.PersonId;
            destination.PersonGuid = original.PersonGuid;
            destination.ResidenceId = original.ResidenceId;
            destination.ResidenceGuid = original.ResidenceGuid;
            return destination;
        }


        public override PersonResidence Convert(IPersonResidence z)
        {
            return (PersonResidence)z;
        }

        public override IPersonResidence Convert(PersonResidence z)
        {
            return z;
        }
    }
}
