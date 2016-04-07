namespace Carrick.DataModel
{
    using SQLite.Net.Attributes;
    
    [Table("PersonScoutingRole")]
    public partial class PersonScoutingRole : TableBase
    {
        public object PersonGuid { get; set; }
        public int? PersonId { get; set; }
        public object ScoutingRoleGuid { get; set; }
        public int? ScoutingRoleId { get; set; }
    }
}
