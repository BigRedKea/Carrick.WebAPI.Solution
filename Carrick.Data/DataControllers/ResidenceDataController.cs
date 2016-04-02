namespace Carrick.Data.Controllers
{
    using Carrick.Data.Model;

    public class ResidenceDataController : GenericDataController<Residence>
    {

        internal ResidenceDataController(Repository r) : base(r, r.DataModel.Residences)
        {
        }

        protected internal override Residence TransferSpecificProperties(Residence original, ref Residence destination, Authorisation<Residence> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = new Residence(); }

            destination.ResidencePhone = original.ResidencePhone;
            destination.ResidenceAddressLine1 = original.ResidenceAddressLine1;
            destination.ResidenceAddressLine2 = original.ResidenceAddressLine2;
            destination.Area = original.Area;
            destination.PostCode = original.PostCode;

            return destination;
        }
    }
}
