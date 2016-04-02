namespace Carrick.Data.Model
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PersonOrganisationUnit")]
    public partial class PersonOrganisationUnit :TableBase
    {

        public int? OrganisationUnitId { get; set; }

        public Guid? OrganisationUnitGuid { get; set; }

        public int? PersonId { get; set; }

        public Guid? PersonGuid { get; set; }
    }
}
