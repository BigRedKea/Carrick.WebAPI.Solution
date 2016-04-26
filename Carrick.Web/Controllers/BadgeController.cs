
using System;
using System.Web.Http;
using System.Collections.Generic;
using System.Linq;

using Carrick.BusinessLogic;
using Carrick.ServerData.Controllers;
using Carrick.BusinessLogic.Interfaces;
using Carrick.Web.Models;

namespace Carrick.Web.Controllers
{
    [RequireHttps]
    public class BadgeController : ApiController
    {

        private BadgeBusinessLogic _BL
        {
            get
            {
                return BL.Singleton.BadgeBL;
            }
        }

        [Authorize(Roles = "ScoutAdministrator")]
        [Route("api/Badge/search")]
        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<IBadge> SearchActiveItems(string searchText)
        {
            return _BL.SearchActiveItems(searchText, 40);
        }

        [Route("api/Badge/new")]
        [HttpGet]
        public IBadge NewItem()
        {
            return _BL.CreateItem();
        }


        [Route("api/badge/getallitems")]
        [AcceptVerbs("GET")]
        [HttpGet]
        public IBadge[] GetAllItems()
        {
            return _BL.GetAllItems().ToArray<IBadge>();
        }

        [Route("api/Badge/GetActiveEnabledItems")]
        [AcceptVerbs("GET")]
        [HttpGet]
        public IBadge[] GetActiveEnabledItems()
        {
            return _BL.GetActiveEnabledItems().ToArray<IBadge>();
        }
        
        [Route("api/Badge/GetActiveItems")]
        [AcceptVerbs("GET")]
        [HttpGet]
        public IBadge[] GetActiveItems()
        {
            return _BL.GetActiveItems().ToArray<IBadge>();
        }

        [Route("api/Badge/GetUpdatedItems")]
        [AcceptVerbs("GET")]
        [HttpGet]
        public IBadge[] GetUpdatedItems(DateTime updatetimestamp)
        {
            return _BL.GetUpdatedItems(updatetimestamp).ToArray<IBadge>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IBadge Get(int id)
        {
            return _BL.GetItem(id);
        }

        [Route("api/Badge/detail/{id}")]
        [HttpGet]
        [AllowAnonymous]
        public IBadge GetDetail(int Id)
        {
            return _BL.GetItem(Id);
        }

        [Authorize(Roles = "ScoutAdministrator")]
        [Route("api/badge/update")]
        [HttpPost]
        public IBadge Update(Object itm)
        {
            Badge b = Newtonsoft.Json.JsonConvert.DeserializeObject<Badge>(itm.ToString());
            return _BL.ModifyItem(b);
        }

        [Authorize(Roles = "ScoutAdministrator")]
        [Route("api/badge/delete/{id}")]
        [AcceptVerbs("DELETE")]
        [HttpPost]
        public void DeleteItem(int id)
        {
            _BL.DeleteItem(id);
        }
    }
}

