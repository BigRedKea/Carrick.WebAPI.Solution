
namespace Carrick.BusinessLogic.Interfaces
{
    using System;

    public interface ILocation : ITableBase
    {

        string LocationName { get; set; }

        string WebLink { get; set; }

        int? Lattitude { get; set; }

        int? Longitude { get; set; }
    }
}
