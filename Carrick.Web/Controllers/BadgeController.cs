using Carrick.BusinessLogic;
using Carrick.ServerData.Controllers;
using Carrick.DataModel;
using System;
using System.Web.Http;
using System.Collections.Generic;
using System.Linq;

namespace Carrick.Web.Controllers
{
    [RequireHttps]
    public class BadgeController : ApiController
    {

        private BadgeDataProvider datacontroller
        {
            get
            {
                return BusinessModel.Singleton.BadgeDataController;
            }
        }

        [Authorize(Roles = "ScoutAdministrator")]
        [Route("api/Badge/search")]
        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<Badge> SearchActiveItems(string searchText)
        {
            return datacontroller.SearchActiveItems(searchText, 40);
        }

        [Route("api/Badge/new")]
        [HttpGet]
        public Badge NewItem()
        {
            return new Badge();
        }


        // GET api/values
        [AcceptVerbs("GET")]
        [HttpGet]
        public Badge[] Get()
        {
            return datacontroller.GetAllItems().ToArray<Badge>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public Badge[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<Badge>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public Badge Get(int id)
        {
            return datacontroller.GetItem(id);
        }

        [Route("api/Badge/detail/{id}")]
        [HttpGet]
        [AllowAnonymous]
        public Badge GetDetail(int Id)
        {
            return datacontroller.GetItem(Id);
        }

        [Authorize(Roles = "ScoutAdministrator")]
        [Route("api/Badge/Save")]
        [HttpPost]
        public Badge SaveItem(Badge itm)
        {
            return datacontroller.SaveItem(itm);
        }

        [Authorize(Roles = "ScoutAdministrator")]
        [Route("api/Badge/delete/{id}")]
        [AcceptVerbs("DELETE")]
        [HttpPost]
        public void DeleteItem(int Id)
        {
            datacontroller.DeleteItem(Id);
        }
    }
}

