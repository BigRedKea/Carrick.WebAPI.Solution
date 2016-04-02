using Carrick.BusinessLogic;
using Carrick.Data.Controllers;
using Carrick.Data.Model;
using System;
using System.Web.Http;

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
        public ScoutingRole[] Get()
        {
            return datacontroller.GetAllItems();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public ScoutingRole[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp);
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public ScoutingRole Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("POST")]
        [HttpPost]
        public ScoutingRole Insert([FromBody]ScoutingRole s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("PUT")]
        [HttpPut]
        public ScoutingRole Update(int id, [FromBody] ScoutingRole s)
        {
            return datacontroller.UpdateItem(s);
        }

        // DELETE api/values/5
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("DELETE")]
        [HttpDelete]
        public ScoutingRole Delete(int id)
        {
            return datacontroller.DeleteItem(id);
        }
    }
}
