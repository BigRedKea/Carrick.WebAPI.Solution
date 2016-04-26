using Carrick.ServerData.Controllers;


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
