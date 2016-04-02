namespace Carrick.Data.Model
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("BadgeRequest")]
    public partial class BadgeRequest : TableBase
    {
        public int? BadgeId { get; set; }

        public Guid? BadgeGuid { get; set; }

        public int? PersonId { get; set; }

        public Guid? PersonGuid { get; set; }

        public int? LeaderAssignedId { get; set; }

        public Guid? LeaderAssignedGuid { get; set; }

        public int? AuthorisedById { get; set; }

        public Guid? AuthorisedByGuid { get; set; }

        public DateTime? PresentedDateTime { get; set; }

        public int? OrderID { get; set; }

        public Guid? OrderGuid { get; set; }

        public bool? BadgeMissingFromOrder { get; set; }
    }
}
