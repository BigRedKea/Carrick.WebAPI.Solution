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
    public class PersonSignInController : ApiController
        {


        private PersonSignInBusinessLogic _BL
        {
            get
            {
                return BL.Singleton.PersonSignInBL;
            }
        }

        [Route("api/personsignin/getallitems")]
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonSignIn[] GetAllItems()
        {
            return _BL.GetAllItems().ToArray<IPersonSignIn>();
        }


        [Route("api/personsignin/getupdateditems/{updatetimestamp}")]
        [AcceptVerbs("GET")]
        [HttpGet]
        [AllowAnonymous]
        public IPersonSignIn[] GetUpdatedItems(String updatetimestamp)
        {
            DateTime d = DateTime.Parse(updatetimestamp);
            return _BL.GetUpdatedItems(d).ToArray<IPersonSignIn>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonSignIn[] Get(DateTime updatetimestamp)
        {
            return _BL.GetUpdatedItems(updatetimestamp).ToArray<IPersonSignIn>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonSignIn Get(int id)
        {
            return _BL.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public IPersonSignIn Insert([FromBody]IPersonSignIn s)
        {
            return _BL.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IPersonSignIn Update(int id, [FromBody] IPersonSignIn s)
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

