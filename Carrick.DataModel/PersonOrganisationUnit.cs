namespace Carrick.DataModel
{
    using BusinessLogic.Interfaces;
    using SQLite.Net.Attributes;
    using System;

    [Table("PersonOrganisationUnit")]
    public partial class PersonOrganisationUnit :TableBase, IPersonOrganisationUnit
    {

        public int? OrganisationUnitId { get; set; }
        public Guid? OrganisationUnitGuid { get; set; }

        public int? PersonId { get; set; }
        public Guid? PersonGuid { get; set; }


        public IRelationshipKey PersonKey()
        {
            IRelationshipKey key = new RelationshipKey();
            key.Id = PersonId;
            key.RowGuid = PersonGuid;
            return key;
        }

        public IRelationshipKey OrganisationUnitKey()
        {
            IRelationshipKey key = new RelationshipKey();
            key.Id = OrganisationUnitId;
            key.RowGuid = OrganisationUnitGuid;
            return key;
        }
    }
}
