namespace Carrick.Web.Controllers
{
    using Carrick.BusinessLogic;
    using Carrick.ServerData.Controllers;
    using Carrick.Server.DataModel;
    using System;
    using System.Linq;
    using System.Web.Http;
    using BusinessLogic.Interfaces;

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
        public IPersonPerson[] Get()
        {
            return datacontroller.GetAllItems().ToArray<IPersonPerson>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonPerson[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<IPersonPerson>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonPerson Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public IPersonPerson Insert([FromBody]IPersonPerson s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IPersonPerson Update(int id, [FromBody] IPersonPerson s)
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

