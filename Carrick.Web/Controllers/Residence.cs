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

        private ResidenceBusinessLogic _BL
        {
            get
            {
                return BL.Singleton.ResidenceBL;
            }
        }

        [Route("api/residence/getallitems")]
        [AcceptVerbs("GET")]
        [HttpGet]
        public IResidence[] GetAllItems()
        {
            return _BL.GetAllItems().ToArray<IResidence>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IResidence[] Get(DateTime updatetimestamp)
        {
            return _BL.GetUpdatedItems(updatetimestamp).ToArray<IResidence>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IResidence Get(int id)
        {
            return _BL.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public IResidence Insert([FromBody] IResidence s)
        {
            return _BL.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IResidence Update(int id, [FromBody]  IResidence s)
        {
            return _BL.ModifyItem(s);
        }

        // DELETE api/values/5
        [AcceptVerbs("DELETE")]
        [HttpDelete]
        public void Delete(int id)
        {
            _BL.DeleteItem(id);
        }
    }
}

