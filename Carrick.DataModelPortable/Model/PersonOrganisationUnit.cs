namespace Carrick.DataModel
{

    using System;
    using SQLite.Net.Attributes;
    
    [Table("PersonOrganisationUnit")]
    public partial class PersonOrganisationUnit :TableBase
    {

        public int? OrganisationUnitId { get; set; }

        public Guid OrganisationUnitGuid { get; set; }

        public int? PersonId { get; set; }

        public Guid PersonGuid { get; set; }
    }
}
