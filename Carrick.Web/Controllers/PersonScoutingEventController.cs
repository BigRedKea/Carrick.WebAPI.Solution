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
    public class PersonScoutingEventController : ApiController
    {

        private PersonScoutingEventBusinessLogic _BL
        {
            get
            {
                return BL.Singleton.PersonScoutingEventBL;
            }
        }

        // GET api/values
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonScoutingEvent[] Get()
        {
            return _BL.GetAllItems().ToArray<IPersonScoutingEvent>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonScoutingEvent[] Get(DateTime updatetimestamp)
        {
            return _BL.GetUpdatedItems(updatetimestamp).ToArray<IPersonScoutingEvent>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonScoutingEvent Get(int id)
        {
            return _BL.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public IPersonScoutingEvent Insert([FromBody] IPersonScoutingEvent s)
        {
            return _BL.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IPersonScoutingEvent Update(int id, [FromBody] IPersonScoutingEvent s)
        {
            return _BL.ModifyItem(s);
        }

        // DELETE api/values/5
        [AcceptVerbs("DELETE")]
        [HttpDelete]
        public void Delete(int id)
        {
            _BL.DeleteItem(id);
        }
    }
}
