using System;

namespace Scout.BusinessLogic.Interfaces
{

    public interface IPersonPerson : IDataTable
    {
        int? PersonAId { get; set; }

        Guid? PersonAGuid { get; set; }

        int? PersonBId { get; set; }

        Guid? PersonBGuid { get; set; }

        int? PersonRelationshipTypeId { get; set; }

        bool RelationshipCanShareData { get; set; }
    }
}
