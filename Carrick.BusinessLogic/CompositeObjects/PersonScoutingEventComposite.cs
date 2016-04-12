
using Carrick.BusinessLogic.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrick.BusinessLogic.CompositeObjects
{


    public class PersonScoutingEventComposite
    {
        public IPerson Person { get; set; }
        public IScoutingEvent ScoutingEvent { get; set; }
        public IPersonScoutingEvent PersonScoutingEvent { get; set; }
    }

    public delegate void PropertyChangedEventHandler(object x, EventArgs e);
}
