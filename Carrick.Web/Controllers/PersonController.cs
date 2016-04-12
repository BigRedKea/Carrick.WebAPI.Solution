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
        public IPerson[] Get()
        {
            return datacontroller.GetAllItems().ToArray<IPerson>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IPerson[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<IPerson>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPerson Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public IPerson Insert([FromBody]IPerson s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IPerson Update(int id, [FromBody] IPerson s)
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
