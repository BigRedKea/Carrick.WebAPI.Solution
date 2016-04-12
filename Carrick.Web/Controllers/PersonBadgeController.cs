using Carrick.BusinessLogic;
using Carrick.ServerData.Controllers;
using Carrick.Server.DataModel;
using System;
using System.Linq;
using System.Web.Http;
using Carrick.BusinessLogic.Interfaces;

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
        public IPersonBadge[] Get()
        {
            return datacontroller.GetAllItems().ToArray<IPersonBadge>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonBadge[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<IPersonBadge>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonBadge Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public IPersonBadge Insert([FromBody]IPersonBadge s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IPersonBadge Update(int id, [FromBody] IPersonBadge s)
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
