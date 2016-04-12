namespace Carrick.BusinessLogic.Interfaces
{
    using System;
    public interface IPersonScoutingRole : ITableBase
    {
        int? PersonId { get; set; }
        Guid? PersonGuid { get; set; }
        
        int? ScoutingRoleId { get; set; }
        Guid? ScoutingRoleGuid { get; set; }

        IRelationshipKey PersonKey();

        IRelationshipKey ScoutingRoleKey();
    }
}
