using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employees.Web.Entities;
using Employees.Web.Services;
using Microsoft.AspNetCore.Authorization;
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

        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(db.GetAll());
        }

        [HttpPut("{id}")]
        public ActionResult<Employee> Put(int id, Employee updatedEmployee)
        {
            var model = db.Update(id, updatedEmployee);
            if(model == null)
            {
                return NotFound();
            }
            db.Commit();
            return Ok(model);
        }

        [HttpPost]
        public ActionResult<Employee> Post(Employee newEmployee)
        {
            var createdEmployee = db.Add(newEmployee);
            db.Commit();
            return CreatedAtAction(nameof(Get), new { id = createdEmployee.ID }, newEmployee);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<Employee> Get([FromRoute]int id)
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

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            db.Delete(id);
            db.Commit();
            return Ok();
        }
    }
}