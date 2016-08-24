using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLogic.Handlers;
using Contracts;

namespace Itm_lunchWebAPI.Controllers
{
    public class RestaurantController : ApiController
    {
        public readonly RestaurantHandler _restaurantHandler;

        public RestaurantController()
        {
            _restaurantHandler = new RestaurantHandler();
        }

        public IEnumerable<RestaurantContract> Get()
        {
            return _restaurantHandler.GetAll();
        }

        public IHttpActionResult Get(int id)
        {
            var restaurant = _restaurantHandler.Get(id);
            if (restaurant == null) return NotFound();
            return Ok(restaurant);
        }

        public IHttpActionResult Post(RestaurantContract restaurantContract)
        {
            return _restaurantHandler.Post(restaurantContract) ? (IHttpActionResult) Ok() : BadRequest();
        }

        public IHttpActionResult Delete(int id)
        {
            return _restaurantHandler.Delete(id) ? (IHttpActionResult) Ok() : BadRequest();
        }
    }
}