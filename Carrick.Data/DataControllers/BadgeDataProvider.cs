namespace Carrick.Data.Controllers
{
    using Carrick.DataModel;
    using System.Linq;
    using System;
    using System.Collections.Generic;
    public class BadgeDataProvider : GenericDataProvider<Badge>
    {

        internal BadgeDataProvider(Repository r) : base(r, r.DataModel.Badges)
        {
        }

        public override IEnumerable<Badge> GetAllItems()
        {
            IEnumerable<Badge> p = _GetAllItems().OrderBy(x => x.BadgeSort);

            return CopyData(p, AuthorisationGet);
        }

        public IEnumerable<Badge> SearchActiveItems(string searchText, int Limit)
        {
            searchText = searchText ?? "";

            IEnumerable<Badge> p = _GetActiveItems().OrderBy(x => x.BadgeSort)
                    .Where(x => x.BadgeName.Contains(searchText) ||
                    x.BadgeLevel.Contains(searchText)
            )
            .Take(Limit);

            return CopyData(p, AuthorisationGet);
        }


        public override IEnumerable<Badge> GetActiveItems()
        {
            IEnumerable<Badge> p = _GetActiveItems().OrderBy(x => x.BadgeSort);

            return CopyData(p, AuthorisationGet);
        }

        protected internal override Badge TransferSpecificProperties( Badge original, ref Badge destination, Authorisation <Badge> Authorisation = null)
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