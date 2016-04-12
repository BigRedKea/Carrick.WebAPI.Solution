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
        public IScoutingEvent[] Get()
        {
            return datacontroller.GetAllItems().ToArray<IScoutingEvent>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IScoutingEvent[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<IScoutingEvent>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IScoutingEvent Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("POST")]
        [HttpPost]
        public IScoutingEvent Insert([FromBody]IScoutingEvent s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IScoutingEvent Update(int id, [FromBody] IScoutingEvent s)
        {
            return datacontroller.ModifyItem(s);
        }

        // DELETE api/values/5
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("DELETE")]
        [HttpDelete]
        public IScoutingEvent Delete(int id)
        {
            return datacontroller.DeleteItem(id);
        }
    }
}
