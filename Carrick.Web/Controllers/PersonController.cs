namespace Carrick.Web.Controllers
{
    using Carrick.BusinessLogic;
    using Carrick.Data.Controllers;
    using Carrick.Data.Model;
    using System;
    using System.Web.Http;

    [Authorize]
    [RequireHttps]
    public class PersonController : ApiController
    {

        private PersonDataController datacontroller
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
            return datacontroller.GetAllItems();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public Person[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp);
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
            return datacontroller.UpdateItem(s);
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
