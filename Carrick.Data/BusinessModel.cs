using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carrick.Data;
using Carrick.DataModel;
using Carrick.Data.Controllers;

namespace Carrick.BusinessLogic
{
    public class BusinessModel : Repository
    {
        public static BusinessModel Singleton = new BusinessModel();

    }
}
