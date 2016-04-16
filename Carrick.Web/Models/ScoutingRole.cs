
using Carrick.BusinessLogic.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Carrick.Web.Models
{
    [Table("ScoutingRole")]
    public class ScoutingRole : TableBase, IScoutingRole
    {
        [StringLength(10)]
        public string ShortText { get; set; }

        [MaxLength(50)]
        [StringLength(50)]
        public String Description { get; set; }
    }
}
