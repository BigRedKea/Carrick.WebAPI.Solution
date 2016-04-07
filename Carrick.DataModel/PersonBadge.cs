using SQLite.Net.Attributes;
using System;

namespace Carrick.DataModel
{
    

    [Table("PersonBadge")]
    public partial class PersonBadge : TableBase
    {
        public object PersonGuid;

        public int? BadgeId { get; set; }

        public int? PersonId { get; set; }

        public int? LeaderAssignedId { get; set; }

        public int? AuthorisedById { get; set; }

        public DateTime? PresentedDateTime { get; set; }

        public int? OrderID { get; set; }

        public bool? BadgeMissingFromOrder { get; set; }
        public object BadgeGuid { get; set; }
        public object LeaderAssignedGuid { get; set; }
        public object AuthorisedByGuid { get; set; }
    }
}
