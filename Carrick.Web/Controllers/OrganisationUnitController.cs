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
    public class OrganisationUnitController : ApiController
    {

        private OrganisationUnitDataProvider datacontroller
        {
            get
            {
                return BusinessModel.Singleton.OrganisationUnitDataController;

            }
        }

        // GET api/values
        [AcceptVerbs("GET")]
        [HttpGet]
        public IOrganisationUnit[] Get()
        {
            return datacontroller.GetAllItems().ToArray<IOrganisationUnit>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IOrganisationUnit[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<IOrganisationUnit>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IOrganisationUnit Get(int id)
        {
            return datacontroller.GetItem(id);
        }

        [Authorize(Roles = "ScoutAdministrator")]
        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public IOrganisationUnit Insert([FromBody]IOrganisationUnit s)
        {
            return datacontroller.InsertItem(s);
        }

        [Authorize(Roles = "ScoutAdministrator")]
        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IOrganisationUnit Update(int id, [FromBody] IOrganisationUnit s)
        {
            return datacontroller.ModifyItem(s);
        }

        [Authorize(Roles = "ScoutAdministrator")]
        // DELETE api/values/5
        [AcceptVerbs("DELETE")]
        [HttpDelete]
        public void Delete(int id)
        {
             datacontroller.DeleteItem(id);
        }
    }
}
