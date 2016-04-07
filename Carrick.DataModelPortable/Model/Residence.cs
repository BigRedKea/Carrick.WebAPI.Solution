
namespace Carrick.DataModel
{
    using SQLite.Net.Attributes;
    
    [Table("Residence")]
    public partial class Residence :TableBase
    {

        [MaxLength(50)]
        public string ResidencePhone { get; set; }

        [MaxLength(256)]
        public string ResidenceAddressLine1 { get; set; }

        [MaxLength(256)]
        public string ResidenceAddressLine2 { get; set; }

        [MaxLength(50)]
        public string Area { get; set; }

        [MaxLength(10)]
        public string PostCode { get; set; }
    }
}
