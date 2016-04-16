using Carrick.ServerData.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrick.Web
{
    internal class BL : BusinessLogic.BusinessLogic
    {
        BL()
        {
            DataProviders = new Repository();
        }

        internal static BL Singleton{ get; set; } = new BL();
    }
}
