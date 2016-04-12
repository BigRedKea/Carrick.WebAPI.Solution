
namespace Carrick.Server.DataModel
{
    using BusinessLogic.Interfaces;
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table ("Location")]
    public class Location: TableBase, ILocation
    {
        [MaxLength(50)]
        public string LocationName { get; set; }

        [MaxLength(256)]
        public string WebLink { get; set; }

        public int? Lattitude { get; set; }

        public int? Longitude { get; set; }
    }
}
