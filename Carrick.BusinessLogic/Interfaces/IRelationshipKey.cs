using System;

namespace Carrick.BusinessLogic.Interfaces
{
    public interface IRelationshipKey
    {
            int? LocalId { get; set; }
            int? Id { get; set; }
            Guid? RowGuid { get; set; }
    }
}
