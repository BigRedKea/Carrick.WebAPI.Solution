namespace Carrick.Web.Controllers
{
    using Carrick.BusinessLogic;
    using Carrick.ServerData.Controllers;

    using System;
    using System.Web.Http;
    using System.Linq;
    using BusinessLogic.Interfaces;
    [Authorize]
    [RequireHttps]
    public class ResidenceController : ApiController
        {

        private ResidenceDataProvider datacontroller
        {
            get
            {
                return BusinessModel.Singleton.ResidenceDataController;

            }
        }

        // GET api/values
        [AcceptVerbs("GET")]
        [HttpGet]
        public IResidence[] Get()
        {
            return datacontroller.GetAllItems().ToArray<IResidence>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IResidence[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<IResidence>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IResidence Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public IResidence Insert([FromBody] IResidence s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IResidence Update(int id, [FromBody]  IResidence s)
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

