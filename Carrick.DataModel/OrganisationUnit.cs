
namespace Carrick.DataModel
{
    using SQLite.Net.Attributes;
    
    [Table("OrganisationUnit")]
    public partial class OrganisationUnit :TableBase
    {
        public int? ParentOrganisationUnitId { get; set; }

        [MaxLength(50)]
        [StringLength(50)]
        public string Description { get; set; }

        [MaxLength(50)]
        [StringLength(50)]
        public string FileStorageURL { get; set; }
        public string PatrolColour { get; set; }
        public object ParentOrganisationUnitGuid { get; set; }
    }
}
