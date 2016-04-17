namespace Carrick.ServerData.Controllers
{
    using System;
    using Carrick.BusinessLogic.Interfaces;
    using Carrick.Web.Models;
    using System.Collections.Generic;
    using System.Linq;
    public class PersonBadgeDataProvider : GenericDataProvider<IPersonBadge, PersonBadge>
    {

        internal PersonBadgeDataProvider(Repository r) : base(r, r.DataModel.PersonBadges)
        {
        }

        protected internal override IPersonBadge TransferSpecificProperties( IPersonBadge original, ref PersonBadge destination, Authorisation<IPersonBadge> Authorisation = null)
        {
            //AuthorisationPerson ap = (AuthorisationPerson)Authorisation;
            if (destination == null) { destination = Convert(CreateItem()); }
            destination.BadgeId = original.BadgeId;
            destination.BadgeGuid = original.BadgeGuid;
            destination.PersonId = original.PersonId;
            destination.PersonGuid = original.PersonGuid;
            destination.LeaderAssignedId = original.LeaderAssignedId;
            destination.LeaderAssignedGuid = original.LeaderAssignedGuid;
            destination.AuthorisedById = original.AuthorisedById;
            destination.AuthorisedByGuid = original.AuthorisedByGuid;
            destination.PresentedTimeStamp = original.PresentedTimeStamp;
            destination.OrderID = original.OrderID;
            destination.BadgeMissingFromOrder = original.BadgeMissingFromOrder;
            return destination;
        }

        internal IEnumerable<IPersonBadge> GetActiveItemsForPerson(int personId)
        {   
            IEnumerable<PersonBadge> p = _GetActiveItems()
                    .Where(x => x.PersonId == personId);

            return CopyData(p, AuthorisationGet);
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