
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrick.BusinessLogic.CompositeObjects
{

    using Carrick.DataModel;

    public class PersonScoutingEventComposite
    {
        public Person Person { get; set; }
        public ScoutingEvent ScoutingEvent { get; set; }
        public PersonScoutingEvent PersonScoutingEvent { get; set; }
    }

    public delegate void PropertyChangedEventHandler(object x, EventArgs e);
}
