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
    public class PersonPersonController : ApiController
        {

        private PersonPersonBusinessLogic _BL
        {
            get
            {
                return BL.Singleton.PersonPersonBL;
            }
        }

        [Route("api/personperson/getallitems")]
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonPerson[] GetAllItems()
        {
            return _BL.GetAllItems().ToArray<IPersonPerson>();
        }

        [Route("api/personperson/getupdateditems/{updatetimestamp}")]
        [AcceptVerbs("GET")]
        [HttpGet]
        [AllowAnonymous]
        public IPersonPerson[] GetUpdatedItems(String updatetimestamp)
        {
            DateTime d = DateTime.Parse(updatetimestamp);
            return _BL.GetUpdatedItems(d).ToArray<IPersonPerson>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonPerson[] Get(DateTime updatetimestamp)
        {
            return _BL.GetUpdatedItems(updatetimestamp).ToArray<IPersonPerson>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonPerson Get(int id)
        {
            return _BL.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public IPersonPerson Insert([FromBody]IPersonPerson s)
        {
            return _BL.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IPersonPerson Update(int id, [FromBody] IPersonPerson s)
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

