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
    public class PersonController : ApiController
    {

        private PersonBusinessLogic _BL
        {
            get
            {
                return BL.Singleton.PersonBL;
            }
        }

        [Route("api/person/getallitems")]
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPerson[] GetAllItems()
        {
            return _BL.GetAllItems().ToArray<IPerson>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IPerson[] Get(DateTime updatetimestamp)
        {
            return _BL.GetUpdatedItems(updatetimestamp).ToArray<IPerson>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPerson Get(int id)
        {
            return _BL.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public IPerson Insert([FromBody]IPerson s)
        {
            return _BL.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IPerson Update(int id, [FromBody] IPerson s)
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
