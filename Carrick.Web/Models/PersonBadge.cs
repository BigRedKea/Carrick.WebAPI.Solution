namespace Carrick.Web.Models
{
    using BusinessLogic.Interfaces;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PersonBadge")]
    public partial class PersonBadge : TableBase, IPersonBadge
    {

        public int? BadgeId { get; set; }
        public Guid? BadgeGuid { get; set; }

        public int? PersonId { get; set; }
        public Guid? PersonGuid { get; set; }

        public int? LeaderAssignedId { get; set; }
        public Guid? LeaderAssignedGuid { get; set; }

        public int? AuthorisedById { get; set; }
        public Guid? AuthorisedByGuid { get; set; }

        public DateTime? PresentedTimeStamp { get; set; }

        public int? OrderID { get; set; }

        public bool? BadgeMissingFromOrder { get; set; }

        public IRelationshipKey BadgeKey()
        {
            IRelationshipKey key = new RelationshipKey();
            key.Id = BadgeId;
            key.RowGuid = BadgeGuid;
            return key;
        }

        public IRelationshipKey PersonKey()
        {
            RelationshipKey key = new RelationshipKey();
            key.Id = PersonId;
            key.RowGuid = PersonGuid;
            return key;
        }

        public IRelationshipKey LeaderAssignedKey()
        {
            IRelationshipKey key = new RelationshipKey();
            key.Id = LeaderAssignedId;
            key.RowGuid = LeaderAssignedGuid;
            return key;
        }
        
        public IRelationshipKey AuthorisedByKey()
        {
            IRelationshipKey key = new RelationshipKey();
            key.Id = AuthorisedById;
            key.RowGuid = AuthorisedByGuid;
            return key;
        }
    }
}
