namespace Carrick.Data.Controllers
{
    using Carrick.Data.Model;

    public class BadgeRequestDataController : GenericDataController<BadgeRequest>
    {

        internal BadgeRequestDataController(Repository r) : base(r, r.DataModel.BadgeRequests)
        {
        }

        protected internal override BadgeRequest TransferSpecificProperties( BadgeRequest original, ref BadgeRequest destination, Authorisation<BadgeRequest> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = new BadgeRequest(); }
            destination.BadgeId = original.BadgeId;
            destination.BadgeGuid = original.BadgeGuid;
            destination.PersonId = original.PersonId;
            destination.PersonGuid = original.PersonGuid;
            destination.LeaderAssignedId = original.LeaderAssignedId;
            destination.LeaderAssignedGuid = original.LeaderAssignedGuid;
            destination.AuthorisedById = original.AuthorisedById;
            destination.AuthorisedByGuid = original.AuthorisedByGuid;
            destination.PresentedDateTime = original.PresentedDateTime;
            destination.OrderID = original.OrderID;
            destination.BadgeMissingFromOrder = original.BadgeMissingFromOrder;
            return destination;
        }

        public Person GetPerson(BadgeRequest BadgeRequest)
        {
            if (BadgeRequest.PersonId.HasValue)
            {
                return Repository.PersonDataController.GetItem(BadgeRequest.PersonId.Value);
            }
            return null;
        }

        public Badge GetBadge(BadgeRequest BadgeRequest)
        {
            if (BadgeRequest.BadgeId.HasValue) {
                return Repository.BadgeDataController.GetItem(BadgeRequest.BadgeId.Value);
            }
            return null;
        }

        public Person GetLeaderAssigned(BadgeRequest BadgeRequest)
        {
            if (BadgeRequest.LeaderAssignedId.HasValue)
            {
                return Repository.PersonDataController.GetItem(BadgeRequest.LeaderAssignedId.Value);
            }
            return null;
        }

        public Person GetAuthorisedBy(BadgeRequest BadgeRequest)
        {
            if (BadgeRequest.AuthorisedById.HasValue)
            {
                return Repository.PersonDataController.GetItem(BadgeRequest.AuthorisedById.Value);
            }
            return null;
        }

    }
}