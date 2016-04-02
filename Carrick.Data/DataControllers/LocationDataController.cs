namespace Carrick.Data.Controllers
{
    using Carrick.Data.Model;


    public class LocationDataController : GenericDataController<Location>
    {
        internal LocationDataController(Repository r) : base(r, r.DataModel.Locations)
        {
        }

        protected internal override Location TransferSpecificProperties(Location original, ref Location destination, Authorisation<Location> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = new Location(); }

            destination.Lattitude= original.Lattitude;
            destination.LocationName = original.LocationName;
            destination.Longitude = original.Longitude;
            destination.WebLink = original.WebLink;
            return destination;
        }

    }
}
