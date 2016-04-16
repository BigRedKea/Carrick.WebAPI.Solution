namespace Carrick.Web.Models
{
    using BusinessLogic.Interfaces;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PersonScoutingRole")]
    public partial class PersonScoutingRole : TableBase, IPersonScoutingRole
    {
        public int? PersonId { get; set; }
        public Guid? PersonGuid { get; set; }
        

        public int? ScoutingRoleId { get; set; }
        public Guid? ScoutingRoleGuid { get; set; }


        public IRelationshipKey PersonKey()
        {
            IRelationshipKey key = new RelationshipKey();
            key.Id = PersonId;
            key.RowGuid = PersonGuid;
            return key;
        }


        public IRelationshipKey ScoutingRoleKey()
        {
            IRelationshipKey key = new RelationshipKey();
            key.Id = ScoutingRoleId;
            key.RowGuid = ScoutingRoleGuid;
            return key;
        }
    }
}
