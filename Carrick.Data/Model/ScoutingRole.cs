namespace Carrick.Data.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Scout.BusinessLogic.Interfaces;

    [Table("ScoutingRole")]
    public partial class ScoutingRole :TableBase, IScoutingRole
    {

        [StringLength(32)]
        public string Description { get; set; }

        [StringLength(10)]
        public string ShortText { get; set; }
    }
}
