
namespace Carrick.BusinessLogic.Interfaces
{
    using System;
    public interface IOrganisationUnit : ITableBase
    {
        string Description { get; set; }

        string FileStorageURL { get; set; }

        string PatrolColour { get; set; }

        int? ParentOrganisationUnitId { get; set; }
        Guid? ParentOrganisationUnitGuid { get; set; }

        IRelationshipKey ParentOrganisationUnitKey();

    }
}
