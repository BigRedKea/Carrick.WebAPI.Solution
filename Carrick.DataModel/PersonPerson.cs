namespace Carrick.DataModel
{
    using System;
    using SQLite.Net.Attributes;
    using BusinessLogic.Interfaces;

    [Table("PersonPerson")]
    public partial class PersonPerson : TableBase, IPersonPerson
    {
        public int? PersonAId { get; set; }
        public Guid? PersonAGuid { get; set; }

        public int? PersonBId { get; set; }
        public Guid? PersonBGuid { get; set; }

        public int? PersonRelationshipTypeId { get; set; }

        public bool RelationshipCanShareData { get; set; }

        public IRelationshipKey PersonAKey()
        {
            IRelationshipKey key = new RelationshipKey();
            key.Id = PersonAId;
            key.RowGuid = PersonAGuid;
            return key;
        }

        public IRelationshipKey PersonBKey()
        {
            IRelationshipKey key = new RelationshipKey();
            key.Id = PersonBId;
            key.RowGuid = PersonBGuid;
            return key;
        }
    }
}
