namespace Carrick.Data.Model
{

    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ScoutingRole")]
    public partial class ScoutingRole :TableBase
    {

        [StringLength(32)]
        public string Description { get; set; }

        [StringLength(10)]
        public string ShortText { get; set; }
    }
}
