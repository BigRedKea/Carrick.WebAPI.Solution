namespace Carrick.Web.Controllers
{
    using Carrick.BusinessLogic;
    using Carrick.ServerData.Controllers;
    using Carrick.DataModel;
    using System;
    using System.Web.Http;
    using System.Linq;

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
        public Residence[] Get()
        {
            return datacontroller.GetAllItems().ToArray<Residence>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public Residence[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<Residence>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public Residence Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public Residence Insert([FromBody] Residence s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public Residence Update(int id, [FromBody]  Residence s)
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

