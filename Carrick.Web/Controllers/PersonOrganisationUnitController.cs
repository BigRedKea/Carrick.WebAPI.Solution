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
    public class PersonOrganisationUnitController : ApiController
    {

        private PersonOrganisationUnitDataProvider datacontroller
        {
            get
            {
                return BusinessModel.Singleton.PersonOrganisationUnitDataController;

            }
        }

        // GET api/values
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonOrganisationUnit[] Get()
        {
            return datacontroller.GetAllItems().ToArray<IPersonOrganisationUnit>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonOrganisationUnit[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<IPersonOrganisationUnit>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonOrganisationUnit Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public IPersonOrganisationUnit Insert([FromBody]IPersonOrganisationUnit s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IPersonOrganisationUnit Update(int id, [FromBody] IPersonOrganisationUnit s)
        {
            return datacontroller.ModifyItem(s);
        }

        // DELETE api/values/5
        [AcceptVerbs("DELETE")]
        [HttpDelete]
        public IPersonOrganisationUnit Delete(int id)
        {
            return datacontroller.DeleteItem(id);
        }
    }
}
