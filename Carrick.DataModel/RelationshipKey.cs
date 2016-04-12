using Carrick.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrick.DataModel
{
    public class RelationshipKey :IRelationshipKey
    {
        public int? LocalId { get; set; }
        public int? Id { get; set; }
        public Guid? RowGuid { get; set; }

    }
}
