using Carrick.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrick.BusinessLogic.Interfaces
{
    public interface IDataProviders
    {
        Object GetProvider(Type t);
    }
}
