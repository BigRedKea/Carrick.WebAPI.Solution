using Carrick.BusinessLogic.Interfaces;
using SQLite.Net.Attributes;
using System;

namespace Carrick.DataModel
{
    [Table("ScoutingRole")]
    public class ScoutingRole : TableBase, IScoutingRole
    {
        [MaxLength(10)]
        public string ShortText { get; set; }

        [MaxLength(50)]
        public String Description { get; set; }
    }
}
