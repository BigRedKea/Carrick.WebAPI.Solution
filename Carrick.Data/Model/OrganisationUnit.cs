namespace Carrick.Data.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Scout.BusinessLogic.Interfaces;

    [Table("OrganisationUnit")]
    public partial class OrganisationUnit :TableBase, IOrganisationUnit
    {
        public int? ParentOrganisationUnitId { get; set; }

        public Guid? ParentOrganisationUnitGuid { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(256)]
        public string FileStorageURL { get; set; }
    }
}
