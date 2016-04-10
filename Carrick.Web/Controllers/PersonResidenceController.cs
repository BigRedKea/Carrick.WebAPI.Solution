namespace Carrick.Web.Controllers
{
    using Carrick.BusinessLogic;
    using Carrick.ServerData.Controllers;
    using Carrick.DataModel;
    using System;
    using System.Linq;
    using System.Web.Http;

    [Authorize]
    [RequireHttps]
    public class PersonResidenceController : ApiController
        {

        private PersonResidenceDataProvider datacontroller
        {
            get
            {
                return BusinessModel.Singleton.PersonResidenceDataController;

            }
        }

        // GET api/values
        [AcceptVerbs("GET")]
        [HttpGet]
        public PersonResidence[] Get()
        {
            return datacontroller.GetAllItems().ToArray<PersonResidence>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public PersonResidence[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<PersonResidence>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public PersonResidence Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public PersonResidence Insert([FromBody]PersonResidence s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public PersonResidence Update(int id, [FromBody] PersonResidence s)
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

