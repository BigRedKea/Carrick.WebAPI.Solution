
namespace Carrick.DataModel
{
    using SQLite.Net.Attributes;
    
    using System;
    [Table("PersonResidence")]
    public partial class PersonResidence : TableBase
    {

        public int? PersonId { get; set; }
        public Guid? PersonGuid { get; set; }

        public int? ResidenceId { get; set; }
        public Guid? ResidenceGuid { get; set; }

        public RelationshipKey PersonKey()
        {
            RelationshipKey key = new RelationshipKey();
            key.Id = PersonId;
            key.RowGuid = PersonGuid;
            return key;
        }

        public RelationshipKey ResidenceKey()
        {
            RelationshipKey key = new RelationshipKey();
            key.Id = ResidenceId;
            key.RowGuid = ResidenceGuid;
            return key;
        }
    }
}
