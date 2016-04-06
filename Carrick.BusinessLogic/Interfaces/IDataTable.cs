using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scout.BusinessLogic.Interfaces
{
    public interface IDataTable
    {
       
        int Id { get; set; }

        int LocalId { get; set; }

        Guid? RowGuid { get; set; }

        bool IsDeleted { get; set; }

        bool IsDirty { get; set; }

        DateTime? RowLastUpdated { get; set; }

    }
}
