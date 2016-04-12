namespace Carrick.ServerData.Controllers
{
    using BusinessLogic.Interfaces;
    using Carrick.Server.DataModel;

    public class PersonBadgeDataProvider : GenericDataProvider<IPersonBadge, PersonBadge>
    {

        internal PersonBadgeDataProvider(Repository r) : base(r, r.DataModel.PersonBadges)
        {
        }

        protected internal override IPersonBadge TransferSpecificProperties( IPersonBadge original, ref IPersonBadge destination, Authorisation<IPersonBadge> Authorisation = null)
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

        public IPerson GetPerson(IPersonBadge PersonBadge)
        {
            if (PersonBadge.PersonId.HasValue)
            {
                return Repository.PersonDataController.GetItem(PersonBadge.PersonId.Value);
            }
            return null;
        }

        public IBadge GetBadge(IPersonBadge PersonBadge)
        {
            if (PersonBadge.BadgeId.HasValue) {
                return Repository.BadgeDataController.GetItem(PersonBadge.BadgeId.Value);
            }
            return null;
        }

        public IPerson GetLeaderAssigned(IPersonBadge PersonBadge)
        {
            if (PersonBadge.LeaderAssignedId.HasValue)
            {
                return Repository.PersonDataController.GetItem(PersonBadge.LeaderAssignedId.Value);
            }
            return null;
        }

        public IPerson GetAuthorisedBy(PersonBadge PersonBadge)
        {
            if (PersonBadge.AuthorisedById.HasValue)
            {
                return Repository.PersonDataController.GetItem(PersonBadge.AuthorisedById.Value);
            }
            return null;
        }


        public override PersonBadge Convert(IPersonBadge z)
        {
            return (PersonBadge)z;
        }

        public override IPersonBadge Convert(PersonBadge z)
        {
            return z;
        }

    }
}