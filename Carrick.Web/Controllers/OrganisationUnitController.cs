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
        public OrganisationUnit[] Get()
        {
            return datacontroller.GetAllItems().ToArray<OrganisationUnit>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public OrganisationUnit[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<OrganisationUnit>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public OrganisationUnit Get(int id)
        {
            return datacontroller.GetItem(id);
        }

        [Authorize(Roles = "ScoutAdministrator")]
        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public OrganisationUnit Insert([FromBody]OrganisationUnit s)
        {
            return datacontroller.InsertItem(s);
        }

        [Authorize(Roles = "ScoutAdministrator")]
        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public OrganisationUnit Update(int id, [FromBody] OrganisationUnit s)
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
