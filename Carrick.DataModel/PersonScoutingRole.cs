namespace Carrick.DataModel
{
    using SQLite.Net.Attributes;
    using System;

    [Table("PersonScoutingRole")]
    public partial class PersonScoutingRole : TableBase
    {
        public int? PersonId { get; set; }
        public Guid? PersonGuid { get; set; }
        

        public int? ScoutingRoleId { get; set; }
        public Guid? ScoutingRoleGuid { get; set; }


        public RelationshipKey PersonKey()
        {
            RelationshipKey key = new RelationshipKey();
            key.Id = PersonId;
            key.RowGuid = PersonGuid;
            return key;
        }


        public RelationshipKey ScoutingRoleKey()
        {
            RelationshipKey key = new RelationshipKey();
            key.Id = ScoutingRoleId;
            key.RowGuid = ScoutingRoleGuid;
            return key;
        }
    }
}
