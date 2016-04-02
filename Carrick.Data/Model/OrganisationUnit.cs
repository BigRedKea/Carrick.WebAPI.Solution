namespace Carrick.Data.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("OrganisationUnit")]
    public partial class OrganisationUnit :TableBase
    {
        public int? ParentOrganisationUnitId { get; set; }

        public Guid? ParentOrganisationUnitGuid { get; set; }

        [StringLength(50)]
        public string Description { get; set; }
    }
}
