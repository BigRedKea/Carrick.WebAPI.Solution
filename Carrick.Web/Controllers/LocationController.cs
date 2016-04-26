
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
    public class LocationController : ApiController
    {

        private LocationBusinessLogic _BL
        {
            get
            {
                return BL.Singleton.LocationBL;
            }
        }

        [Authorize(Roles = "ScoutAdministrator")]
        [Route("api/Location/search")]
        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<ILocation> SearchActiveItems(string searchText)
        {
            return _BL.SearchActiveItems(searchText, 40);
        }

        [Route("api/Location/new")]
        [HttpGet]
        public ILocation NewItem()
        {
            return _BL.CreateItem();
        }


        [Route("api/Location/getallitems")]
        [AcceptVerbs("GET")]
        [HttpGet]
        [AllowAnonymous]
        public ILocation[] GetAllItems()
        {
            return _BL.GetAllItems().ToArray<ILocation>();
        }

        
        [Route("api/Location/GetActiveItems")]
        [AcceptVerbs("GET")]
        [HttpGet]
        [AllowAnonymous]
        public ILocation[] GetActiveItems()
        {
            return _BL.GetActiveItems().ToArray<ILocation>();
        }

        [Route("api/Location/getupdateditems/{updatetimestamp}")]
        [AcceptVerbs("GET")]
        [HttpGet]
        [AllowAnonymous]
        public ILocation[] GetUpdatedItems(String updatetimestamp)
        {
            DateTime d = DateTime.Parse(updatetimestamp);
            return _BL.GetUpdatedItems(d).ToArray<ILocation>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public ILocation Get(int id)
        {
            return _BL.GetItem(id);
        }

        [Route("api/Location/detail/{id}")]
        [HttpGet]
        [AllowAnonymous]
        public ILocation GetDetail(int Id)
        {
            return _BL.GetItem(Id);
        }

        [Authorize(Roles = "ScoutAdministrator")]
        [Route("api/location/update")]
        [HttpPost]
        public ILocation Update(Object itm)
        {
            Location b = Newtonsoft.Json.JsonConvert.DeserializeObject<Location>(itm.ToString());
            return _BL.ModifyItem(b);
        }

        [Authorize(Roles = "ScoutAdministrator")]
        [Route("api/location/delete/{id}")]
        [AcceptVerbs("DELETE")]
        [HttpPost]
        public void DeleteItem(int id)
        {
            _BL.DeleteItem(id);
        }
    }
}

