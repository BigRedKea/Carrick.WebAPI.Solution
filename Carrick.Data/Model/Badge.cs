namespace Carrick.Data.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Scout.BusinessLogic.Interfaces;

    [Table("Badge")]
    public partial class Badge : TableBase, IBadge
    {

        [StringLength(256)]
        public string BadgeName { get; set; }

        [StringLength(50)]
        public string BadgeLevel { get; set; }

        [Column(TypeName = "image")]
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
