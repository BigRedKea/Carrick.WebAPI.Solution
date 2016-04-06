
namespace Scout.BusinessLogic.Interfaces
{

    public interface IBadge : IDataTable
    {

        string BadgeName { get; set; }

        string BadgeLevel { get; set; }

        byte[] BadgeImage { get; set; }

        int? BadgeSort { get; set; }

        bool? BadgeEnabled { get; set; }

        int? Stock { get; set; }

        int? TargetStock { get; set; }

        int? YearService { get; set; }

        int? NightsUnderCanvas { get; set; }

        int? Walkabout { get; set; }
    }
}
