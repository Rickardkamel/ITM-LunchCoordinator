using System.Collections.Generic;
using System.Web.Http;
using BusinessLogic.Handlers;
using Contracts;

namespace Itm_lunchWebAPI.Controllers
{
    public class LunchController : ApiController
    {
        private readonly LunchHandler _lunchHandler;

        public LunchController()
        {
            _lunchHandler = new LunchHandler();
        }

        public IEnumerable<LunchContract> Get()
        {
            return _lunchHandler.GetAll();
        }

        public IHttpActionResult Get(int id)
        {
            var lunch = _lunchHandler.Get(id);
            if (lunch == null) return NotFound();
            return Ok(lunch);
        }

        [Route("api/lunch/InsertEmployee/{employeeId}/{lunchId}")]
        public IHttpActionResult InsertEmployee(int employeeId, int lunchId)
        {

            return _lunchHandler.InsertEmployee(employeeId, lunchId) ? (IHttpActionResult) Ok() : BadRequest();

        }

        public IHttpActionResult Post(LunchContract lunchContract)
        {
            return _lunchHandler.Post(lunchContract) ? (IHttpActionResult)Ok() : BadRequest();
        }

        public IHttpActionResult Delete(int id)
        {
            return _lunchHandler.Delete(id) ? (IHttpActionResult)Ok() : BadRequest();
        }
    }
}
