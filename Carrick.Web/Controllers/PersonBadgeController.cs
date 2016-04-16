using Carrick.BusinessLogic;
using Carrick.ServerData.Controllers;
using System;
using System.Linq;
using System.Web.Http;
using Carrick.BusinessLogic.Interfaces;
using Carrick.BusinessLogic.CompositeObjects;

namespace Carrick.Web.Controllers
{
    [Authorize]
    [RequireHttps]
    public class PersonBadgeController : ApiController
    {

        private PersonBadgeBusinessLogic _BL
        {
            get
            {
                return BL.Singleton.PersonBadgeBL;
            }
        }

        // GET api/values
        [AcceptVerbs("GET")]
        [HttpGet]
        [AllowAnonymous]
        [Route("api/personbadge/getallitems")]
        public IPersonBadge[] GetAllItems()
        {
            return _BL.GetAllItems().ToArray<IPersonBadge>();
        }

        [AcceptVerbs("GET")]
        [HttpGet]
        [AllowAnonymous]
        [Route("api/personbadge/getactiveitems")]
        public IPersonBadge[] GetActiveItems()
        {
            return _BL.GetActiveItems().ToArray<IPersonBadge>();
        }


        [Route("api/personbadge/getactiveitemsforperson")]
        [AcceptVerbs("GET")]
        [AllowAnonymous]
        [HttpGet]
        public PersonBadgeComposite[] GetActiveItemsForPerson(int id)
        {
            return _BL.GetBadgeRequestsforPerson(id).ToArray<PersonBadgeComposite>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonBadge[] Get(DateTime updatetimestamp)
        {
            return _BL.GetUpdatedItems(updatetimestamp).ToArray<IPersonBadge>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonBadge Get(int id)
        {
            return _BL.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public IPersonBadge Insert([FromBody]IPersonBadge s)
        {
            return _BL.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IPersonBadge Update(int id, [FromBody] IPersonBadge s)
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
