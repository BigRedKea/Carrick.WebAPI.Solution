using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrick.Data.Model
{
    public class Location: TableBase
    {
        [StringLength(50)]
        public string LocationName { get; set; }

        [StringLength(256)]
        public string WebLink { get; set; }

        public int? Lattitude { get; set; }

        public int? Longitude { get; set; }
    }
}
