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
    public class PersonOrganisationUnitController : ApiController
    {

        private PersonOrganisationUnitBusinessLogic _BL
        {
            get
            {
                return BL.Singleton.PersonOrganisationUnitBL;
            }
        }

        // GET api/values
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonOrganisationUnit[] Get()
        {
            return _BL.GetAllItems().ToArray<IPersonOrganisationUnit>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonOrganisationUnit[] Get(DateTime updatetimestamp)
        {
            return _BL.GetUpdatedItems(updatetimestamp).ToArray<IPersonOrganisationUnit>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IPersonOrganisationUnit Get(int id)
        {
            return _BL.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public IPersonOrganisationUnit Insert([FromBody]IPersonOrganisationUnit s)
        {
            return _BL.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public IPersonOrganisationUnit Update(int id, [FromBody] IPersonOrganisationUnit s)
        {
            return _BL.ModifyItem(s);
        }

        // DELETE api/values/5
        [AcceptVerbs("DELETE")]
        [HttpDelete]
        public IPersonOrganisationUnit Delete(int id)
        {
            return _BL.DeleteItem(id);
        }
    }
}
