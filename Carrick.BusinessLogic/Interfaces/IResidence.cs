namespace Carrick.BusinessLogic.Interfaces
{
    using System;

    public interface IResidence : ITableBase
    {
        string ResidencePhone { get; set; }

        string ResidenceAddressLine1 { get; set; }

        string ResidenceAddressLine2 { get; set; }

        string Area { get; set; }

        string PostCode { get; set; }
    }
}
