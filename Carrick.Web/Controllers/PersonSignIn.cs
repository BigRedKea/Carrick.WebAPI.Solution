﻿namespace Carrick.Web.Controllers
{
    using Carrick.BusinessLogic;
    using Carrick.Data.Controllers;
    using Carrick.DataModel;
    using System;
    using System.Linq;
    using System.Web.Http;

    [Authorize]
    [RequireHttps]
    public class PersonSignInController : ApiController
        {

        private PersonSignInDataProvider datacontroller
        {
            get
            {
                return BusinessModel.Singleton.PersonSignInDataController;

            }
        }

        // GET api/values
        [AcceptVerbs("GET")]
        [HttpGet]
        public PersonSignIn[] Get()
        {
            return datacontroller.GetAllItems().ToArray<PersonSignIn>(); ;
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public PersonSignIn[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<PersonSignIn>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public PersonSignIn Get(int id)
        {
            return datacontroller.GetItem(id);
        }


        // POST api/values
        [AcceptVerbs("POST")]
        [HttpPost]
        public PersonSignIn Insert([FromBody]PersonSignIn s)
        {
            return datacontroller.InsertItem(s);
        }


        // PUT api/values/5
        [AcceptVerbs("PUT")]
        [HttpPut]
        public PersonSignIn Update(int id, [FromBody] PersonSignIn s)
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

