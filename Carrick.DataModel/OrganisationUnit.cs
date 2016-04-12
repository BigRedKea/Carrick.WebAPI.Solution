
namespace Carrick.DataModel
{
    using SQLite.Net.Attributes;
    using System;
    [Table("OrganisationUnit")]
    public partial class OrganisationUnit :TableBase
    {
        

        [MaxLength(50)]
        [StringLength(50)]
        public string Description { get; set; }

        [MaxLength(50)]
        [StringLength(50)]
        public string FileStorageURL { get; set; }

        [MaxLength(50)]
        [StringLength(50)]
        public string PatrolColour { get; set; }

        public int? ParentOrganisationUnitId { get; set; }
        public Guid? ParentOrganisationUnitGuid { get; set; }


        public RelationshipKey ParentOrganisationUnitKey()
        {
            RelationshipKey key = new RelationshipKey();
            key.Id = ParentOrganisationUnitId;
            key.RowGuid = ParentOrganisationUnitGuid;
            return key;
        }
    }
}
