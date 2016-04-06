using Scout.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scout.BusinessLogic.CompositeObjects
{
    public class PersonBadgeComposite
    {
        public IPerson Person { get; set; }
        public IBadge Badge { get; set; }
        public IPersonBadge PersonBadge { get; set; }  
    }
}
