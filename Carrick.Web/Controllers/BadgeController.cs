
using System;
using System.Web.Http;
using System.Collections.Generic;
using System.Linq;

using Carrick.BusinessLogic;
using Carrick.ServerData.Controllers;
using Carrick.Server.DataModel;
using Carrick.BusinessLogic.Interfaces;

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
        public IEnumerable<IBadge> SearchActiveItems(string searchText)
        {
            return datacontroller.SearchActiveItems(searchText, 40);
        }

        [Route("api/Badge/new")]
        [HttpGet]
        public IBadge NewItem()
        {
            return new Badge();
        }


        // GET api/values
        [AcceptVerbs("GET")]
        [HttpGet]
        public IBadge[] Get()
        {
            return datacontroller.GetAllItems().ToArray<IBadge>();
        }


        [AcceptVerbs("GET")]
        [HttpGet]
        public IBadge[] Get(DateTime updatetimestamp)
        {
            return datacontroller.GetUpdatedItems(updatetimestamp).ToArray<IBadge>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IBadge Get(int id)
        {
            return datacontroller.GetItem(id);
        }

        [Route("api/Badge/detail/{id}")]
        [HttpGet]
        [AllowAnonymous]
        public IBadge GetDetail(int Id)
        {
            return datacontroller.GetItem(Id);
        }

        [Authorize(Roles = "ScoutAdministrator")]
        [Route("api/Badge/Save")]
        [HttpPost]
        public IBadge SaveItem(IBadge itm)
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

