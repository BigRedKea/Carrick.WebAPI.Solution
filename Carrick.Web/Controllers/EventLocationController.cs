
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
    public class EventLocationController : ApiController
    {

        private EventLocationBusinessLogic _BL
        {
            get
            {
                return BL.Singleton.EventLocationBL;
            }
        }

        [Authorize(Roles = "ScoutAdministrator")]
        [Route("api/eventlocation/search")]
        [HttpGet]
        [AllowAnonymous]
        public IEnumerable<IEventLocation> SearchActiveItems(string searchText)
        {
            return _BL.SearchActiveItems(searchText, 40);
        }

        [Route("api/eventlocation/new")]
        [HttpGet]
        public IEventLocation NewItem()
        {
            return _BL.CreateItem();
        }


        [Route("api/eventlocation/getallitems")]
        [AcceptVerbs("GET")]
        [HttpGet]
        [AllowAnonymous]
        public IEventLocation[] GetAllItems()
        {
            return _BL.GetAllItems().ToArray<IEventLocation>();
        }

        
        [Route("api/eventlocation/GetActiveItems")]
        [AcceptVerbs("GET")]
        [HttpGet]
        [AllowAnonymous]
        public IEventLocation[] GetActiveItems()
        {
            return _BL.GetActiveItems().ToArray<IEventLocation>();
        }

        [Route("api/eventlocation/getupdateditems/{updatetimestamp}")]
        [AcceptVerbs("GET")]
        [HttpGet]
        [AllowAnonymous]
        public IEventLocation[] GetUpdatedItems(String updatetimestamp)
        {
            DateTime d = DateTime.Parse(updatetimestamp);
            return _BL.GetUpdatedItems(d).ToArray<IEventLocation>();
        }

        // GET api/values/5
        [AcceptVerbs("GET")]
        [HttpGet]
        public IEventLocation Get(int id)
        {
            return _BL.GetItem(id);
        }

        [Route("api/eventlocation/detail/{id}")]
        [HttpGet]
        [AllowAnonymous]
        public IEventLocation GetDetail(int Id)
        {
            return _BL.GetItem(Id);
        }

        [Authorize(Roles = "ScoutAdministrator")]
        [Route("api/eventlocation/update")]
        [HttpPost]
        public IEventLocation Update(Object itm)
        {
            EventLocation b = Newtonsoft.Json.JsonConvert.DeserializeObject<EventLocation>(itm.ToString());
            return _BL.ModifyItem(b);
        }

        [Authorize(Roles = "ScoutAdministrator")]
        [Route("api/eventlocation/delete/{id}")]
        [AcceptVerbs("DELETE")]
        [HttpPost]
        public void DeleteItem(int id)
        {
            _BL.DeleteItem(id);
        }
    }
}

