namespace Carrick.ServerData.Controllers
{
    using Carrick.BusinessLogic.Interfaces;
    using Carrick.Web.Models;

    public class LocationDataProvider : GenericDataProvider<ILocation, Location>
    {
        internal LocationDataProvider(Repository r) : base(r, r.DataModel.Locations)
        {
        }

        protected internal override ILocation TransferSpecificProperties(ILocation original, ref Location destination, Authorisation<ILocation> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = Convert(CreateItem()); }

            destination.Lattitude= original.Lattitude;
            destination.LocationName = original.LocationName;
            destination.Longitude = original.Longitude;
            destination.WebLink = original.WebLink;
            return destination;
        }

        public override Location Convert(ILocation z)
        {
            return (Location)z;
        }

        public override ILocation Convert(Location z)
        {
            return z;
        }

    }
}
