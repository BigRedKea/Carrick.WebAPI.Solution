using SQLite.Net.Attributes;
using System;
using Scout.BusinessLogic.Interfaces;
namespace ScoutDataModelPortable.Model
{
    [Table("ScoutingRole")]
    public class ScoutingRole : TableBase , IScoutingRole
    {
        [MaxLength(16)]
        public String Description { get; set; }
    }
}
