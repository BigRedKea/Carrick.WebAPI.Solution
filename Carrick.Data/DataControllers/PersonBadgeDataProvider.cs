namespace Carrick.ServerData.Controllers
{
    using Carrick.DataModel;

    public class PersonBadgeDataProvider : GenericDataProvider<PersonBadge>
    {

        internal PersonBadgeDataProvider(Repository r) : base(r, r.DataModel.PersonBadges)
        {
        }

        protected internal override PersonBadge TransferSpecificProperties( PersonBadge original, ref PersonBadge destination, Authorisation<PersonBadge> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = new PersonBadge(); }
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

        public Person GetPerson(PersonBadge PersonBadge)
        {
            if (PersonBadge.PersonId.HasValue)
            {
                return Repository.PersonDataController.GetItem(PersonBadge.PersonId.Value);
            }
            return null;
        }

        public Badge GetBadge(PersonBadge PersonBadge)
        {
            if (PersonBadge.BadgeId.HasValue) {
                return Repository.BadgeDataController.GetItem(PersonBadge.BadgeId.Value);
            }
            return null;
        }

        public Person GetLeaderAssigned(PersonBadge PersonBadge)
        {
            if (PersonBadge.LeaderAssignedId.HasValue)
            {
                return Repository.PersonDataController.GetItem(PersonBadge.LeaderAssignedId.Value);
            }
            return null;
        }

        public Person GetAuthorisedBy(PersonBadge PersonBadge)
        {
            if (PersonBadge.AuthorisedById.HasValue)
            {
                return Repository.PersonDataController.GetItem(PersonBadge.AuthorisedById.Value);
            }
            return null;
        }

    }
}