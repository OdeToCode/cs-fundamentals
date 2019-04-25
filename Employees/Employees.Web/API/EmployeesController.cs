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
            var employees = db.GetAllQuery();

            employees = employees.Where(e => !String.IsNullOrEmpty(e.FirstName));

            return Ok(employees);
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

        // DELETE /api/employees
        // PUT /api/employees/{id}/activestatus/0|1

        // [HttpPut("{id:int}/activestatus/{status:int}")]
        [HttpPost("{id:int}")]
        public ActionResult Delete(int id)
        {
            db.Delete(id);
            db.Commit();
            return Ok();
        }
    }
}