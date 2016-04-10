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
    public class PersonController : ApiController
    {

        private PersonDataProvider datacontroller
        {
            get
            {
                return BusinessModel.Singleton.PersonDataController;

            }
        }

        // GET api/values
        [AcceptVerbs("GET")]
        [HttpGet]
        public Person[] Get()
        {
            return datacontroller.GetAllItems().ToArray<Person>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public Person[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<Person>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public Person Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public Person Insert([FromBody]Person s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public Person Update(int id, [FromBody] Person s)
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
