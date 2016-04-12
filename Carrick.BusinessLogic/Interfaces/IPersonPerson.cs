namespace Carrick.BusinessLogic.Interfaces
{
    using System;
    public interface IPersonPerson : ITableBase
    {
        int? PersonAId { get; set; }
        Guid? PersonAGuid { get; set; }

        int? PersonBId { get; set; }
        Guid? PersonBGuid { get; set; }

        int? PersonRelationshipTypeId { get; set; }

        bool RelationshipCanShareData { get; set; }

        IRelationshipKey PersonAKey();

        IRelationshipKey PersonBKey();

    }
}
