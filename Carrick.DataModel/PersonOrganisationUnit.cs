namespace Carrick.DataModel
{
    using SQLite.Net.Attributes;
    using System;
    
    [Table("PersonOrganisationUnit")]
    public partial class PersonOrganisationUnit :TableBase
    {

        public int? OrganisationUnitId { get; set; }

        public Guid? OrganisationUnitGuid { get; set; }

        public int? PersonId { get; set; }

        public Guid? ParentGuid { get; set; }
        public object PersonGuid { get; set; }
    }
}
