using System;

namespace Scout.BusinessLogic.Interfaces
{

    public interface IResidence : IDataTable
    {

        string ResidencePhone { get; set; }

        string ResidenceAddressLine1 { get; set; }

        string ResidenceAddressLine2 { get; set; }

        string Area { get; set; }

        string PostCode { get; set; }
    }
}
