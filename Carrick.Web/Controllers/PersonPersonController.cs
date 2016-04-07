namespace Carrick.Web.Controllers
{
    using Carrick.BusinessLogic;
    using Carrick.Data.Controllers;
    using Carrick.DataModel;
    using System;
    using System.Linq;
    using System.Web.Http;

    [Authorize]
    [RequireHttps]
    public class PersonPersonController : ApiController
        {

        private PersonPersonDataProvider datacontroller
        {
            get
            {
                return BusinessModel.Singleton.PersonPersonDataController;

            }
        }

        // GET api/values
        [AcceptVerbs("GET")]
        [HttpGet]
        public PersonPerson[] Get()
        {
            return datacontroller.GetAllItems().ToArray<PersonPerson>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public PersonPerson[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<PersonPerson>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public PersonPerson Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public PersonPerson Insert([FromBody]PersonPerson s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public PersonPerson Update(int id, [FromBody] PersonPerson s)
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

