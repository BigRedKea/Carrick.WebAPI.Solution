﻿namespace Carrick.Web.Controllers
{
    using Carrick.BusinessLogic;
    using Carrick.Data.Controllers;
    using Carrick.Data.Model;
    using System;
    using System.Web.Http;

    [Authorize]
    [RequireHttps]
    public class PersonScoutingRoleController : ApiController
        {

        private PersonScoutingRoleDataController datacontroller
        {
            get
            {
                return BusinessModel.Singleton.PersonScoutingRoleDataController;

            }
        }

        // GET api/values
        [AcceptVerbs("GET")]
        [HttpGet]
        public PersonScoutingRole[] Get()
        {
            return datacontroller.GetAllItems();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public PersonScoutingRole[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp);
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public PersonScoutingRole Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("POST")]
        [HttpPost]
        public PersonScoutingRole Insert([FromBody]PersonScoutingRole s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("PUT")]
        [HttpPut]
        public PersonScoutingRole Update(int id, [FromBody] PersonScoutingRole s)
        {
            return datacontroller.UpdateItem(s);
        }

        // DELETE api/values/5
        [Authorize(Roles = "ScoutAdministrator")]
        [AcceptVerbs("DELETE")]
        [HttpDelete]
        public void Delete(int id)
        {
            datacontroller.DeleteItem(id);
        }
    }
}
