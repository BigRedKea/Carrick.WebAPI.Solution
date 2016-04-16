using Carrick.BusinessLogic;
using Carrick.ServerData.Controllers;
using System;
using System.Linq;
using System.Web.Http;
using Carrick.BusinessLogic.Interfaces;

namespace Carrick.Web.Controllers
{
    [Authorize]
    [RequireHttps]
    public class OrganisationUnitController : ApiController
    {

        private OrganisationUnitBusinessLogic _BL
        {
            get
            {
                return BL.Singleton.OrganisationUnitBL;
            }
        }

        // GET api/values
        [AcceptVerbs("GET")]
        [HttpGet]
        public IOrganisationUnit[] Get()
        {
            return _BL.GetAllItems().ToArray<IOrganisationUnit>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IOrganisationUnit[] Get(DateTime updatetimestamp)
        {
            return _BL.GetUpdatedItems(updatetimestamp).ToArray<IOrganisationUnit>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IOrganisationUnit Get(int id)
        {
            return _BL.GetItem(id);
        }

        [Authorize(Roles = "ScoutAdministrator")]
        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public IOrganisationUnit Insert([FromBody]IOrganisationUnit s)
        {
            return _BL.InsertItem(s);
        }

        [Authorize(Roles = "ScoutAdministrator")]
        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IOrganisationUnit Update(int id, [FromBody] IOrganisationUnit s)
        {
            return _BL.ModifyItem(s);
        }

        [Authorize(Roles = "ScoutAdministrator")]
        // DELETE api/values/5
        [AcceptVerbs("DELETE")]
        [HttpDelete]
        public void Delete(int id)
        {
             _BL.DeleteItem(id);
        }
    }
}
