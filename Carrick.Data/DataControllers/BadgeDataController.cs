namespace Carrick.Data.Controllers
{
    using Carrick.Data.Model;
    using System.Linq;
    using System;

    public class BadgeDataController : GenericDataController<Badge>
    {

        internal BadgeDataController(Repository r) : base(r, r.DataModel.Badges)
        {
        }

        public override Badge[] GetAllItems()
        {
            Badge[] p = _GetAllItems().OrderBy(x => x.BadgeSort).ToArray<Badge>();

            return CopyData(p, AuthorisationGet);
        }

        public Badge[] SearchActiveItems(string searchText)
        {
            searchText = searchText ?? "";

            Badge[] p = _GetActiveItems().OrderBy(x => x.BadgeSort)
                    .Where(x => x.BadgeName.Contains(searchText) ||
                    x.BadgeLevel.Contains(searchText)
            )
            .Take(20)
            .ToArray<Badge>();

            return CopyData(p, AuthorisationGet);
        }


        public override Badge[] GetActiveItems()
        {
            Badge[] p = _GetActiveItems().OrderBy(x => x.BadgeSort).ToArray<Badge>();

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