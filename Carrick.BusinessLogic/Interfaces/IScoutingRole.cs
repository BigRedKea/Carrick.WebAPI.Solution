using System;

namespace Scout.BusinessLogic.Interfaces
{

    public interface IScoutingRole : IDataTable 
    {
        String Description { get; set; }
    }
}
