namespace ScoutDataModelPortable.Model
{
    using SQLite.Net.Attributes;
    using Scout.BusinessLogic.Interfaces;
    [Table("PersonOrganisationUnit")]
    public partial class PersonOrganisationUnit :TableBase, IPersonOrganisationUnit
    {

        public int? OrganisationUnitId { get; set; }

        public int? PersonId { get; set; }
    }
}
