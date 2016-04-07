using SQLite.Net.Attributes;
using System;

namespace Carrick.DataModel
{
    [Table("ScoutingRole")]
    public class ScoutingRole : TableBase
    {
        [MaxLength(10)]
        [StringLength(10)]
        public string ShortText { get; set; }

        [MaxLength(50)]
        [StringLength(50)]
        public String Description { get; set; }
    }
}
