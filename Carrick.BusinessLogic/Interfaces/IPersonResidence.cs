namespace Carrick.BusinessLogic.Interfaces
{
    using System;
    public interface IPersonResidence : ITableBase
    {

        int? PersonId { get; set; }
        Guid? PersonGuid { get; set; }

        int? ResidenceId { get; set; }
        Guid? ResidenceGuid { get; set; }

        IRelationshipKey PersonKey();

        IRelationshipKey ResidenceKey();

    }
}
