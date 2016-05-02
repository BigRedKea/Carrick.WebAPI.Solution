using Carrick.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrick.Web.Models
{
    public class RelationshipKey : IRelationshipKey
    {
        public int? LocalId { get; set; }
        public int? Id { get; set; }
        public Guid? RowGuid { get; set; }

        public bool Matches(IRelationshipKey obj)
        {
            if (Id == null || obj == null)
            {
                return (RowGuid.Value.ToString() == obj.RowGuid.Value.ToString());
            }
            else
            {
                return (Id.Value == obj.Id.Value);
            }
        }
    }
}
