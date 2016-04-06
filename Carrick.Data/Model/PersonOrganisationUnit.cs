namespace Carrick.Data.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Scout.BusinessLogic.Interfaces;

    [Table("PersonOrganisationUnit")]
    public partial class PersonOrganisationUnit :TableBase, IPersonOrganisationUnit
    {

        public int? OrganisationUnitId { get; set; }

        public Guid? OrganisationUnitGuid { get; set; }

        public int? PersonId { get; set; }

        public Guid? PersonGuid { get; set; }
    }
}
