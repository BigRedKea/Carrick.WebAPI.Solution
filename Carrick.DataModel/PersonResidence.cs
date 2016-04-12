
namespace Carrick.DataModel
{
    using BusinessLogic.Interfaces;
    using SQLite.Net.Attributes;

    using System;
    [Table("PersonResidence")]
    public partial class PersonResidence : TableBase, IPersonResidence
    {

        public int? PersonId { get; set; }
        public Guid? PersonGuid { get; set; }

        public int? ResidenceId { get; set; }
        public Guid? ResidenceGuid { get; set; }

        public IRelationshipKey PersonKey()
        {
            IRelationshipKey key = new RelationshipKey();
            key.Id = PersonId;
            key.RowGuid = PersonGuid;
            return key;
        }

        public IRelationshipKey ResidenceKey()
        {
            IRelationshipKey key = new RelationshipKey();
            key.Id = ResidenceId;
            key.RowGuid = ResidenceGuid;
            return key;
        }
    }
}
