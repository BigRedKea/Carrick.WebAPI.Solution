namespace Carrick.Data.Model
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Residence")]
    public partial class Residence :TableBase
    {

        [StringLength(50)]
        public string ResidencePhone { get; set; }

        [StringLength(256)]
        public string ResidenceAddressLine1 { get; set; }

        [StringLength(256)]
        public string ResidenceAddressLine2 { get; set; }

        [StringLength(50)]
        public string Area { get; set; }

        [StringLength(10)]
        public string PostCode { get; set; }
    }
}
