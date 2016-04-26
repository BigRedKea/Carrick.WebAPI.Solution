namespace Carrick.Web.Controllers
{
    using Carrick.BusinessLogic;
    using Carrick.ServerData.Controllers;
    using System;
    using System.Linq;
    using System.Web.Http;
    using BusinessLogic.Interfaces;
    [Authorize]
    [RequireHttps]
    public class PersonResidenceController : ApiController
        {

        private PersonResidenceBusinessLogic _BL
        {
            get
            {
                return BL.Singleton.PersonResidenceBL;
            }
        }

        [Route("api/personresidence/getallitems")]
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonResidence[] GetAllItems()
        {
            return _BL.GetAllItems().ToArray<IPersonResidence>();
        }

        [Route("api/personresidence/getupdateditems/{updatetimestamp}")]
        [AcceptVerbs("GET")]
        [HttpGet]
        [AllowAnonymous]
        public IPersonResidence[] GetUpdatedItems(String updatetimestamp)
        {
            DateTime d = DateTime.Parse(updatetimestamp);
            return _BL.GetUpdatedItems(d).ToArray<IPersonResidence>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonResidence[] Get(DateTime updatetimestamp)
        {
            return _BL.GetUpdatedItems(updatetimestamp).ToArray<IPersonResidence>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonResidence Get(int id)
        {
            return _BL.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public IPersonResidence Insert([FromBody]IPersonResidence s)
        {
            return _BL.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IPersonResidence Update(int id, [FromBody] IPersonResidence s)
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

