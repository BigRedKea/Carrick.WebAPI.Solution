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
    public class PersonScoutingEventController : ApiController
    {

        private PersonScoutingEventDataProvider datacontroller
        {
            get
            {
                return BusinessModel.Singleton.PersonScoutingEventDataController;

            }
        }

        // GET api/values
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonScoutingEvent[] Get()
        {
            return datacontroller.GetAllItems().ToArray<IPersonScoutingEvent>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonScoutingEvent[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<IPersonScoutingEvent>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonScoutingEvent Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public IPersonScoutingEvent Insert([FromBody] IPersonScoutingEvent s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IPersonScoutingEvent Update(int id, [FromBody] IPersonScoutingEvent s)
        {
            return datacontroller.ModifyItem(s);
        }

        // DELETE api/values/5
        [AcceptVerbs("DELETE")]
        [HttpDelete]
        public void Delete(int id)
        {
            datacontroller.DeleteItem(id);
        }
    }
}
