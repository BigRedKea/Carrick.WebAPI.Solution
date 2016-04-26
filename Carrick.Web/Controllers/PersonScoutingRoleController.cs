namespace Carrick.Web.Controllers
{
    using Carrick.BusinessLogic;
    using Carrick.ServerData.Controllers;
    using System;
    using System.Linq;
    using System.Web.Http;
    using BusinessLogic.Interfaces;
    [Authorize]
    [RequireHttps]
    public class PersonScoutingRoleController : ApiController
        {

        private PersonScoutingRoleBusinessLogic _BL
        {
            get
            {
                return BL.Singleton.PersonScoutingRoleBL;
            }
        }

        [Route("api/personscoutingrole/getallitems")]
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonScoutingRole[] GetAllItems()
        {
            return _BL.GetAllItems().ToArray<IPersonScoutingRole>();
        }

        [Route("api/personscoutingrole/getupdateditems/{updatetimestamp}")]
        [AcceptVerbs("GET")]
        [HttpGet]
        [AllowAnonymous]
        public IPersonScoutingRole[] GetUpdatedItems(String updatetimestamp)
        {
            DateTime d = DateTime.Parse(updatetimestamp);
            return _BL.GetUpdatedItems(d).ToArray<IPersonScoutingRole>();
        }

        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonScoutingRole[] Get(DateTime updatetimestamp)
        {
            return _BL.GetUpdatedItems(updatetimestamp).ToArray<IPersonScoutingRole>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonScoutingRole Get(int id)
        {
            return _BL.GetItem(id);
        }


        // POST api/values
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("POST")]
        [HttpPost]
        public IPersonScoutingRole Insert([FromBody] IPersonScoutingRole s)
        {
            return _BL.InsertItem(s);
        }


        // PUT api/values/5
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IPersonScoutingRole Update(int id, [FromBody] IPersonScoutingRole s)
        {
            return _BL.ModifyItem(s);
        }

        // DELETE api/values/5
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("DELETE")]
        [HttpDelete]
        public void Delete(int id)
        {
            _BL.DeleteItem(id);
        }
    }
}

