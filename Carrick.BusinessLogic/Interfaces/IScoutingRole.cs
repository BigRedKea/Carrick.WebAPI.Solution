namespace Carrick.BusinessLogic.Interfaces
{
    using System;

    public interface IScoutingRole : ITableBase
    {
        string ShortText { get; set; }

        String Description { get; set; }
    }
}
