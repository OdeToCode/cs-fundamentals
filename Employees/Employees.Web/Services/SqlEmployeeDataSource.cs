using System;
using System.Collections.Generic;
using Employees.Web.Data;
using Employees.Web.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Employees.Web.Services
{
    public class SqlEmployeeDataSource : IEmployeeDataSource
    {
        private readonly EmployeesDbContext db;

        public SqlEmployeeDataSource(EmployeesDbContext db)
        {
            this.db = db;
           
        }

        public Employee Add(Employee newEmployee)
        {
            db.Employees.Add(newEmployee);
            return newEmployee;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Employee Delete(int id)
        {
            var employee = Get(id);
            db.Employees.Remove(employee);
            return employee;

        }

        public Employee Get(int id)
        {
            var employee = db.Employees.Include(e => e.TimeCards)
                               .FirstOrDefault(e => e.ID == id);
            return employee;
        }

        public IQueryable<Employee> GetAllQuery()
        {
            return db.Employees.OrderBy(e => e.LastName)
                              .ThenByDescending(e => e.FirstName)
                              .Where(e => e.HireDate < DateTime.Now);
        }

        public IEnumerable<Employee> GetAll()
        {
            return db.Employees.OrderBy(e => e.LastName)
                               .ThenByDescending(e => e.FirstName)
                               .Where(e => e.HireDate < DateTime.Now);
        }

        public Employee Update(int id, Employee updatedEmployee)
        {
            var employee = Get(id);
            employee.FirstName = updatedEmployee.FirstName;
            employee.LastName = updatedEmployee.LastName;
            employee.HireDate = updatedEmployee.HireDate;
            return employee;
        }
    }
}
