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
        public PersonScoutingEvent[] Get()
        {
            return datacontroller.GetAllItems().ToArray<PersonScoutingEvent>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public PersonScoutingEvent[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<PersonScoutingEvent>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public PersonScoutingEvent Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public PersonScoutingEvent Insert([FromBody]PersonScoutingEvent s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public PersonScoutingEvent Update(int id, [FromBody] PersonScoutingEvent s)
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
