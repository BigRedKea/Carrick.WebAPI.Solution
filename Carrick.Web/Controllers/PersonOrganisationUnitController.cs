using Carrick.BusinessLogic;
using Carrick.Data.Controllers;
using Carrick.Data.Model;
using System;
using System.Web.Http;

namespace Carrick.Web.Controllers
{
    [Authorize]
    [RequireHttps]
    public class PersonOrganisationUnitController : ApiController
    {

        private PersonOrganisationUnitDataController datacontroller
        {
            get
            {
                return BusinessModel.Singleton.PersonOrganisationUnitDataController;

            }
        }

        // GET api/values
        [AcceptVerbs("GET")]
        [HttpGet]
        public PersonOrganisationUnit[] Get()
        {
            return datacontroller.GetAllItems();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public PersonOrganisationUnit[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp);
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public PersonOrganisationUnit Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public PersonOrganisationUnit Insert([FromBody]PersonOrganisationUnit s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public PersonOrganisationUnit Update(int id, [FromBody] PersonOrganisationUnit s)
        {
            return datacontroller.UpdateItem(s);
        }

        // DELETE api/values/5
        [AcceptVerbs("DELETE")]
        [HttpDelete]
        public PersonOrganisationUnit Delete(int id)
        {
            return datacontroller.DeleteItem(id);
        }
    }
}
