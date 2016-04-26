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
    public class ScoutingEventController : ApiController
    {

        private ScoutingEventBusinessLogic _BL
        {
            get
            {
                return BL.Singleton.ScoutingEventBL;
            }
        }


        [Route("api/scoutingevent/getallitems")]
        [AcceptVerbs("GET")]
        [HttpGet]
        public IScoutingEvent[] GetAllItems()
        {
            return _BL.GetAllItems().ToArray<IScoutingEvent>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IScoutingEvent[] Get(DateTime updatetimestamp)
        {
            return _BL.GetUpdatedItems(updatetimestamp).ToArray<IScoutingEvent>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IScoutingEvent Get(int id)
        {
            return _BL.GetItem(id);
        }


        // POST api/values
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("POST")]
        [HttpPost]
        public IScoutingEvent Insert([FromBody]IScoutingEvent s)
        {
            return _BL.InsertItem(s);
        }


        // PUT api/values/5
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IScoutingEvent Update(int id, [FromBody] IScoutingEvent s)
        {
            return _BL.ModifyItem(s);
        }

        // DELETE api/values/5
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("DELETE")]
        [HttpDelete]
        public IScoutingEvent Delete(int id)
        {
            return _BL.DeleteItem(id);
        }
    }
}
