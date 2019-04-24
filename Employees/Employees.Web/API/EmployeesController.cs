using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employees.Web.Entities;
using Employees.Web.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employees.Web.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeeDataSource db;

        public EmployeesController(IEmployeeDataSource db)
        {
            this.db = db;
        }

        public IEnumerable<Employee> Get()
        {
            return db.GetAll();
        }

        [Route("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            var model = db.Get(id);
            if(model == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(model);
            }
        }
    }
}