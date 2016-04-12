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
        public IPersonResidence[] Get()
        {
            return datacontroller.GetAllItems().ToArray<IPersonResidence>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonResidence[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<IPersonResidence>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonResidence Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public IPersonResidence Insert([FromBody]IPersonResidence s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IPersonResidence Update(int id, [FromBody] IPersonResidence s)
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

