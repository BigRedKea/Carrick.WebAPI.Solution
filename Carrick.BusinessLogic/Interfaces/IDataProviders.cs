using Carrick.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scout.BusinessLogic.Interfaces
{
    public interface IDataProviders
    {
        Object GetProvider(Type t);
    }
}
