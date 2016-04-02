namespace Carrick.Data.Model
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PersonPerson")]
    public partial class PersonPerson : TableBase
    {
        public int? PersonAId { get; set; }

        public Guid? PersonAGuid { get; set; }

        public int? PersonBId { get; set; }

        public Guid? PersonBGuid { get; set; }

        public int? PersonRelationshipTypeId { get; set; }

        public bool RelationshipCanShareData { get; set; }
    }
}
