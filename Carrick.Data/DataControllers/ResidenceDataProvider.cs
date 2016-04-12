namespace Carrick.ServerData.Controllers
{
    using BusinessLogic.Interfaces;
    using Carrick.Server.DataModel;

    public class ResidenceDataProvider : GenericDataProvider<IResidence, Residence>
    {

        internal ResidenceDataProvider(Repository r) : base(r, r.DataModel.Residences)
        {
        }

        protected internal override IResidence TransferSpecificProperties(IResidence original, ref IResidence destination, Authorisation<IResidence> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = CreateItem(); }

            destination.ResidencePhone = original.ResidencePhone;
            destination.ResidenceAddressLine1 = original.ResidenceAddressLine1;
            destination.ResidenceAddressLine2 = original.ResidenceAddressLine2;
            destination.Area = original.Area;
            destination.PostCode = original.PostCode;

            return destination;
        }


        public override Residence Convert(IResidence z)
        {
            return (Residence)z;
        }

        public override IResidence Convert(Residence z)
        {
            return z;
        }
    }
}
