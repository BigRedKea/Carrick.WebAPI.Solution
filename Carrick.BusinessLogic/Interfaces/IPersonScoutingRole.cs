using System;

namespace Scout.BusinessLogic.Interfaces
{

    public interface IPersonScoutingRole : IDataTable
    {
        int? PersonId { get; set; }

        int? ScoutingRoleId { get; set; }
    }
}
