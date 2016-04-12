namespace Carrick.ServerData.Controllers
{
    using Carrick.Server.DataModel;
    using System.Linq;
    using System;
    using System.Collections.Generic;
    using BusinessLogic.Interfaces;
    public class BadgeDataProvider : GenericDataProvider<IBadge, Badge>
    {

        internal BadgeDataProvider(Repository r) : base(r, r.DataModel.Badges)
        {
            defaultOrder = (Badge t) => t.BadgeSort;
        }

        public override Badge Convert(IBadge z)
        {
            return (Badge)z;
        }

        public override IBadge Convert(Badge z)
        {
            return z;
        }

        public IEnumerable<IBadge> SearchActiveItems(string searchText, int Limit)
        {
            searchText = searchText ?? "";

            IEnumerable<Badge> p = _GetActiveItems().OrderBy(x => x.BadgeName)
                    .Where(x => x.BadgeName.Contains(searchText) ||
                    x.BadgeLevel.Contains(searchText)
            )
            .Take(Limit);

            return CopyData(p, AuthorisationGet);
        }


        protected internal override IBadge TransferSpecificProperties(IBadge original, ref IBadge destination, Authorisation <IBadge> Authorisation = null)
        {
            if (destination == null) { destination = new Badge(); }
            destination.BadgeName = original.BadgeName;
            destination.BadgeLevel = original.BadgeLevel;
            destination.BadgeImage = original.BadgeImage;
            destination.BadgeSort = original.BadgeSort;
            destination.BadgeEnabled = original.BadgeEnabled;
            destination.Stock = original.Stock;
            destination.TargetStock = original.TargetStock;
            destination.YearService = original.YearService;
            destination.NightsUnderCanvas = original.NightsUnderCanvas;
            destination.Walkabout = original.Walkabout;
            return destination;
        }


    }
}