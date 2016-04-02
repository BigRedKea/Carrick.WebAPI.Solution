namespace Carrick.Data.Model
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PersonScoutingRole")]
    public partial class PersonScoutingRole : TableBase
    {
        public int? PersonId { get; set; }

        public Guid? PersonGuid { get; set; }

        public int? ScoutingRoleId { get; set; }

        public Guid? ScoutingRoleGuid { get; set; }
    }
}
