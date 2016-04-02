using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrick.Data.Model
{
    public class DataStoredResponse
    {
        public int Id { get; set; }

        public Guid? RowGuid { get; set; }

        public bool IsDeleted { get; set; } = false;

        public DateTime? RowLastUpdated { get; set; }
    }
}
