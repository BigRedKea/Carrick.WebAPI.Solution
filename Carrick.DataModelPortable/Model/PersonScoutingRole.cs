namespace ScoutDataModelPortable.Model
{
    using SQLite.Net.Attributes;
    using Scout.BusinessLogic.Interfaces;
    [Table("PersonScoutingRole")]
    public partial class PersonScoutingRole : TableBase, IPersonScoutingRole
    {
        public int? PersonId { get; set; }

        public int? ScoutingRoleId { get; set; }
    }
}
