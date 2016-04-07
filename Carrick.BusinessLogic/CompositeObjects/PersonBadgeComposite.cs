
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carrick.DataModel;

namespace Scout.BusinessLogic.CompositeObjects
{
    public class PersonBadgeComposite
    {
        public Person Person { get; set; }
        public Badge Badge { get; set; }
        public PersonBadge PersonBadge { get; set; }  
    }
}
