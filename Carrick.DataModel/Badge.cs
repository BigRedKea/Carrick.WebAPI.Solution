
namespace Carrick.DataModel
{
    using SQLite.Net.Attributes;

    [Table("Badge")]
    public partial class Badge : TableBase
    {

        [MaxLength(256)]
        public string BadgeName { get; set; }

        [MaxLength(50)]
        public string BadgeLevel { get; set; }

        public byte[] BadgeImage { get; set; }

        public int? BadgeSort { get; set; }

        public bool? BadgeEnabled { get; set; }

        public int? Stock { get; set; }

        public int? TargetStock { get; set; }

        public int? YearService { get; set; }

        public int? NightsUnderCanvas { get; set; }

        public int? Walkabout { get; set; }
    }
}
