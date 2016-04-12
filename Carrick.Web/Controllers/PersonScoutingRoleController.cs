namespace Carrick.Web.Controllers
{
    using Carrick.BusinessLogic;
    using Carrick.ServerData.Controllers;
    using Carrick.Server.DataModel;
    using System;
    using System.Linq;
    using System.Web.Http;
    using BusinessLogic.Interfaces;
    [Authorize]
    [RequireHttps]
    public class PersonScoutingRoleController : ApiController
        {

        private PersonScoutingRoleDataProvider datacontroller
        {
            get
            {
                return BusinessModel.Singleton.PersonScoutingRoleDataController;

            }
        }

        // GET api/values
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonScoutingRole[] Get()
        {
            return datacontroller.GetAllItems().ToArray<IPersonScoutingRole>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonScoutingRole[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<IPersonScoutingRole>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonScoutingRole Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("POST")]
        [HttpPost]
        public IPersonScoutingRole Insert([FromBody] IPersonScoutingRole s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IPersonScoutingRole Update(int id, [FromBody] IPersonScoutingRole s)
        {
            return datacontroller.ModifyItem(s);
        }

        // DELETE api/values/5
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("DELETE")]
        [HttpDelete]
        public void Delete(int id)
        {
            datacontroller.DeleteItem(id);
        }
    }
}

