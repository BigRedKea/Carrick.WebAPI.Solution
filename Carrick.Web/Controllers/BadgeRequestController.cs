using Carrick.BusinessLogic;
using Carrick.Data.Controllers;
using Carrick.Data.Model;
using System;
using System.Web.Http;

namespace Carrick.Web.Controllers
{
    [Authorize]
    [RequireHttps]
    public class BadgeRequestController : ApiController
    {

        private BadgeRequestDataController datacontroller
        {
            get
            {
                return BusinessModel.Singleton.BadgeRequestDataController;

            }
        }

        // GET api/values
        [AcceptVerbs("GET")]
        [HttpGet]
        public BadgeRequest[] Get()
        {
            return datacontroller.GetAllItems();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public BadgeRequest[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp);
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public BadgeRequest Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public BadgeRequest Insert([FromBody]BadgeRequest s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public BadgeRequest Update(int id, [FromBody] BadgeRequest s)
        {
            return datacontroller.UpdateItem(s);
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
