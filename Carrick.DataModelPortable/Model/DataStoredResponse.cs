using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoutDataModelPortable.Model
{
    public class DataStoredResponse
    {
        public int Id { get; set; }

        public Guid? RowGUID { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? RowLastUpdated { get; set; }
    }
}
