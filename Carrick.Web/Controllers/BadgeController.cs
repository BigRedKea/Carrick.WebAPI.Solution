using Carrick.BusinessLogic;
using Carrick.Data.Controllers;
using Carrick.Data.Model;
using System;
using System.Web.Http;
using System.Collections.Generic;

namespace Carrick.Web.Controllers
{
    ////[Authorize]
    
    //[RequireHttps]
    //public class BadgeController : ApiController
    //{

    //    private BadgeDataController datacontroller
    //    {
    //        get
    //        {
    //            return BusinessModel.Singleton.BadgeDataController;

    //        }
    //    }

    //    // GET api/values
    //    [AcceptVerbs("GET")]
    //    [AllowAnonymous]
    //    [HttpGet]
    //    public Badge[] Get()
    //    {
    //        return datacontroller.GetAllItems();
    //    }


    //    [AcceptVerbs("GET")]
    //    [HttpGet]
    //    public Badge[] Get(DateTime updatetimestamp)
    //    {
    //        return datacontroller.GetUpdatedItems(updatetimestamp);
    //    }

    //    // GET api/values/5
    //    [AcceptVerbs("GET")]
    //    [HttpGet]
    //    public Badge Get(int id)
    //    {
    //        return datacontroller.GetItem(id);
    //    }


    //    // POST api/values
    //    [Authorize (Roles="ScoutAdministrator")]
    //    [AcceptVerbs("POST")]
    //    [HttpPost]
    //    public DataStoredResponse Insert([FromBody]Badge s)
    //    {
    //        return datacontroller.InsertItem(s);
    //    }


    //    // PUT api/values/5
    //    [Authorize(Roles = "ScoutAdministrator")]
    //    [AcceptVerbs("PUT")]
    //    [HttpPut]
    //    public DataStoredResponse Update(int id, [FromBody] Badge s)
    //    {
    //        return datacontroller.UpdateItem(s);
    //    }

    //    // DELETE api/values/5
    //    [Authorize(Roles = "ScoutAdministrator")]
    //    [AcceptVerbs("DELETE")]
    //    [HttpDelete]
    //    public DataStoredResponse Delete(int id)
    //    {
    //        return datacontroller.DeleteItem(id);
    //    }
    //}



//namespace Angularjs.UIRouting.WebApp.Controllers
//    {
        public class BadgeController : ApiController
        {

        private BadgeDataController datacontroller
        {
            get
            {
                return BusinessModel.Singleton.BadgeDataController;
            }
        }

        [Route("api/Badge/search")]
            [HttpGet]
            public IEnumerable<Badge> SearchActiveItems(string searchText)
            {
                return datacontroller.SearchActiveItems(searchText);
            }

            [Route("api/Badge/new")]
            [HttpGet]
            public Badge NewItem()
            {
                return new Badge();
            }

            [Route("api/Badge/detail/{id}")]
            [HttpGet]
            public Badge GetDetail(int Id)
            {
                return datacontroller.GetItem(Id);
            }

            [Route("api/Badge/Save")]
            [HttpPost]
            public Badge SaveItem(Badge itm)
            {
                return datacontroller.SaveItem(itm);
            }

            [Route("api/Badge/delete/{id}")]
            [HttpPost]
            public void DeleteItem(int Id)
            {
                datacontroller.DeleteItem(Id);
            }
        }
    }

