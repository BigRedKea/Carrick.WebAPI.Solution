using Carrick.BusinessLogic;
using Carrick.Data.Controllers;
using Carrick.DataModel;
using System;
using System.Linq;
using System.Web.Http;

namespace Carrick.Web.Controllers
{
    [Authorize]
    [RequireHttps]
    public class PersonBadgeController : ApiController
    {

        private PersonBadgeDataProvider datacontroller
        {
            get
            {
                return BusinessModel.Singleton.PersonBadgeDataController;

            }
        }

        // GET api/values
        [AcceptVerbs("GET")]
        [HttpGet]
        public PersonBadge[] Get()
        {
            return datacontroller.GetAllItems().ToArray<PersonBadge>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public PersonBadge[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<PersonBadge>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public PersonBadge Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public PersonBadge Insert([FromBody]PersonBadge s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public PersonBadge Update(int id, [FromBody] PersonBadge s)
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
