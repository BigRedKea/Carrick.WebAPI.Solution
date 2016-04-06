using System;

namespace Scout.BusinessLogic.Interfaces
{

    public interface IPersonResidence : IDataTable
    {

        int? PersonId { get; set; }

        int? ResidenceId { get; set; }
    }
}
