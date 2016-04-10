using Carrick.BusinessLogic;
using Carrick.ServerData.Controllers;
using Carrick.DataModel;
using System;
using System.Linq;
using System.Web.Http;

namespace Carrick.Web.Controllers
{
    [Authorize]
    [RequireHttps]
    public class ScoutingEventController : ApiController
    {

        private ScoutingEventDataProvider datacontroller
        {
            get
            {
                return BusinessModel.Singleton.ScoutingEventDataController;

            }
        }

        // GET api/values
        [AcceptVerbs("GET")]
        [HttpGet]
        [AllowAnonymous]
        public ScoutingEvent[] Get()
        {
            return datacontroller.GetAllItems().ToArray<ScoutingEvent>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public ScoutingEvent[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<ScoutingEvent>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public ScoutingEvent Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("POST")]
        [HttpPost]
        public ScoutingEvent Insert([FromBody]ScoutingEvent s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("PUT")]
        [HttpPut]
        public ScoutingEvent Update(int id, [FromBody] ScoutingEvent s)
        {
            return datacontroller.ModifyItem(s);
        }

        // DELETE api/values/5
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("DELETE")]
        [HttpDelete]
        public ScoutingEvent Delete(int id)
        {
            return datacontroller.DeleteItem(id);
        }
    }
}
