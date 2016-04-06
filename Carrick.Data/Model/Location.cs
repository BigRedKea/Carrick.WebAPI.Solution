
namespace Carrick.Data.Model
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Scout.BusinessLogic.Interfaces;

    public class Location: TableBase, ILocation
    {
        [StringLength(50)]
        public string LocationName { get; set; }

        [StringLength(256)]
        public string WebLink { get; set; }

        public int? Lattitude { get; set; }

        public int? Longitude { get; set; }
    }
}
