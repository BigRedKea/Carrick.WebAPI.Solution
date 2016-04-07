
namespace Carrick.DataModel
{
    using System;
    using SQLite.Net.Attributes;


    public class Location: TableBase
    {
        [MaxLength(50)]
        public string LocationName { get; set; }

        [MaxLength(256)]
        public string WebLink { get; set; }

        public int? Lattitude { get; set; }

        public int? Longitude { get; set; }
    }
}
