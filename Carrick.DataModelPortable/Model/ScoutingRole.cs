using SQLite.Net.Attributes;
using System;

namespace Carrick.DataModel
{
    [Table("ScoutingRole")]
    public class ScoutingRole : TableBase
    {
        [MaxLength(16)]
        public String Description { get; set; }
    }
}
