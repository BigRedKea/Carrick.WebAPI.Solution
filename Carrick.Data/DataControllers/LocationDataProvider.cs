namespace Carrick.ServerData.Controllers
{
    using BusinessLogic.Interfaces;
    using Carrick.Server.DataModel;

    public class LocationDataProvider : GenericDataProvider<ILocation, Location>
    {
        internal LocationDataProvider(Repository r) : base(r, r.DataModel.Locations)
        {
        }

        protected internal override ILocation TransferSpecificProperties(ILocation original, ref ILocation destination, Authorisation<ILocation> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = CreateItem() ; }

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
