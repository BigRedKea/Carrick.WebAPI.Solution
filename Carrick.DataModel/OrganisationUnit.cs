
namespace Carrick.DataModel
{
    using BusinessLogic.Interfaces;
    using SQLite.Net.Attributes;
    using System;
    [Table("OrganisationUnit")]
    public partial class OrganisationUnit :TableBase, IOrganisationUnit
    {
        
        [MaxLength(50)]
        public string Description { get; set; }

        [MaxLength(50)]
        public string FileStorageURL { get; set; }

        [MaxLength(50)]
        public string PatrolColour { get; set; }

        public int? ParentOrganisationUnitId { get; set; }
        public Guid? ParentOrganisationUnitGuid { get; set; }


        public IRelationshipKey ParentOrganisationUnitKey()
        {
            IRelationshipKey key = new RelationshipKey();
            key.Id = ParentOrganisationUnitId;
            key.RowGuid = ParentOrganisationUnitGuid;
            return key;
        }
    }
}
