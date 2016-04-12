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
    public class PersonSignInController : ApiController
        {

        private PersonSignInDataProvider datacontroller
        {
            get
            {
                return BusinessModel.Singleton.PersonSignInDataController;

            }
        }

        // GET api/values
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonSignIn[] Get()
        {
            return datacontroller.GetAllItems().ToArray<IPersonSignIn>(); ;
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonSignIn[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<IPersonSignIn>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonSignIn Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public IPersonSignIn Insert([FromBody]IPersonSignIn s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IPersonSignIn Update(int id, [FromBody] IPersonSignIn s)
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

