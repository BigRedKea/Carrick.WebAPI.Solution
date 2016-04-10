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
        public Guid? PersonGuid { get; set; }


        public RelationshipKey PersonKey()
        {
            RelationshipKey key = new RelationshipKey();
            key.Id = PersonId;
            key.RowGuid = PersonGuid;
            return key;
        }

        public RelationshipKey OrganisationUnitKey()
        {
            RelationshipKey key = new RelationshipKey();
            key.Id = OrganisationUnitId;
            key.RowGuid = OrganisationUnitGuid;
            return key;
        }
    }
}
