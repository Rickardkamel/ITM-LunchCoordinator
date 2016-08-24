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
    public class EmployeeController : ApiController
    {
        private readonly EmployeeHandler _employeeHandler;

        public EmployeeController()
        {
            _employeeHandler = new EmployeeHandler();
        }

        public IEnumerable<EmployeeContract> Get()
        {
            return _employeeHandler.GetAll();
        }

        public IHttpActionResult Get(int id)
        {
            var employee = _employeeHandler.Get(id);
            if (employee == null) return NotFound();
            return Ok(employee);
        }

        public IHttpActionResult Post(EmployeeContract employeeContract)
        {

            return _employeeHandler.Post(employeeContract) ? (IHttpActionResult) Ok() : BadRequest();
        }

        public IHttpActionResult Delete(int id)
        {
            return _employeeHandler.Delete(id) ? (IHttpActionResult) Ok() : BadRequest();
        }


    }
}
