namespace Carrick.ServerData.Controllers
{
    using System.Linq;
    using System;
    using System.Collections.Generic;
    using Carrick.BusinessLogic.Interfaces;
    using Carrick.Web.Models;

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




        protected internal override IBadge TransferSpecificProperties(IBadge original, ref Badge destination, Authorisation <IBadge> Authorisation = null)
        {
            if (destination == null) { destination = Convert(CreateItem()); }
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