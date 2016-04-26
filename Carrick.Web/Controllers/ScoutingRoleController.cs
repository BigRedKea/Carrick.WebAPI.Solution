using Carrick.BusinessLogic;
using Carrick.ServerData.Controllers;
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

        private ScoutingRoleBusinessLogic _BL
        {
            get
            {
                return BL.Singleton.ScoutingRoleBL;
            }
        }

        [Route("api/scoutingrole/getallitems")]
        [AcceptVerbs("GET")]
        [HttpGet]
        public IScoutingRole[] GetAllItems()
        {
            return _BL.GetAllItems().ToArray<IScoutingRole>();
        }


        [Route("api/scoutingrole/getupdateditems/{updatetimestamp}")]
        [AcceptVerbs("GET")]
        [HttpGet]
        [AllowAnonymous]
        public IScoutingRole[] GetUpdatedItems(String updatetimestamp)
        {
            DateTime d = DateTime.Parse(updatetimestamp);
            return _BL.GetUpdatedItems(d).ToArray<IScoutingRole>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IScoutingRole[] Get(DateTime updatetimestamp)
        {
            return _BL.GetUpdatedItems(updatetimestamp).ToArray<IScoutingRole>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IScoutingRole Get(int id)
        {
            return _BL.GetItem(id);
        }


        // POST api/values
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("POST")]
        [HttpPost]
        public IScoutingRole Insert([FromBody] IScoutingRole s)
        {
            return _BL.InsertItem(s);
        }


        // PUT api/values/5
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IScoutingRole Update(int id, [FromBody] IScoutingRole s)
        {
            return _BL.ModifyItem(s);
        }

        // DELETE api/values/5
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("DELETE")]
        [HttpDelete]
        public IScoutingRole Delete(int id)
        {
            return _BL.DeleteItem(id);
        }
    }
}
