namespace Carrick.BusinessLogic.Interfaces
{
    using System;
    public interface IPersonOrganisationUnit : ITableBase
    {

        int? OrganisationUnitId { get; set; }
        Guid? OrganisationUnitGuid { get; set; }

        int? PersonId { get; set; }
        Guid? PersonGuid { get; set; }

        IRelationshipKey PersonKey();

        IRelationshipKey OrganisationUnitKey();

    }
}
