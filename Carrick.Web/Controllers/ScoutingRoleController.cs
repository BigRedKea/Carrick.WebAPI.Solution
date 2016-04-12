using Carrick.BusinessLogic;
using Carrick.ServerData.Controllers;
using Carrick.Server.DataModel;
using System;
using System.Linq;
using System.Web.Http;
using Carrick.BusinessLogic.Interfaces;

namespace Carrick.Web.Controllers
{
    [Authorize]
    [RequireHttps]
    public class ScoutingRoleController : ApiController
    {

        private ScoutingRoleDataController datacontroller
        {
            get
            {
                return BusinessModel.Singleton.ScoutingRoleDataController;
            }         
        }

        // GET api/values
        [AcceptVerbs("GET")]
        [HttpGet]
        public IScoutingRole[] Get()
        {
            return datacontroller.GetAllItems().ToArray<IScoutingRole>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IScoutingRole[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<IScoutingRole>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IScoutingRole Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("POST")]
        [HttpPost]
        public IScoutingRole Insert([FromBody] IScoutingRole s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IScoutingRole Update(int id, [FromBody] IScoutingRole s)
        {
            return datacontroller.ModifyItem(s);
        }

        // DELETE api/values/5
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("DELETE")]
        [HttpDelete]
        public IScoutingRole Delete(int id)
        {
            return datacontroller.DeleteItem(id);
        }
    }
}
