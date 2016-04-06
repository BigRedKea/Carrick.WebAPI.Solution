
namespace ScoutDataModelPortable.Model
{
    using SQLite.Net.Attributes;
    using Scout.BusinessLogic.Interfaces;
    [Table("OrganisationUnit")]
    public partial class OrganisationUnit :TableBase, IOrganisationUnit
    {
        public int? ParentOrganisationUnitId { get; set; }

        [MaxLength(50)]
        public string Description { get; set; }

        [MaxLength(50)]
        public string FileStorageURL { get; set; }
        public string PatrolColour { get; set; }
    }
}
