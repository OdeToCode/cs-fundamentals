using System;
using System.Collections.Generic;
using System.Linq;
using Employees.Web.Entities;

namespace Employees.Web.Services
{
    public class InMemoryEmployeeDataSource : IEmployeeDataSource
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee { ID = 1, FirstName="Scott", LastName="Allen", HireDate = new DateTime(2005, 1, 1) },
            new Employee { ID = 2, FirstName="Joy", LastName="Allen", HireDate = new DateTime(2010, 1, 1) },
            new Employee { ID = 3, FirstName="Christopher", LastName="Allen", HireDate = new DateTime(2007, 1, 1) },
            new Employee { ID = 4, FirstName="Alex", LastName="Allen", HireDate = new DateTime(2012, 1, 1) },

        };

        public Employee Add(Employee newEmployee)
        {
            newEmployee.ID = employees.Max(e => e.ID) + 1;
            employees.Add(newEmployee);
            return newEmployee;
        }

        public IEnumerable<Employee> GetAll()
        {
            return employees.OrderByDescending(e => e.HireDate.Year);
        }

        public Employee Get(int id)
        {
            return employees.SingleOrDefault(e => e.ID == id);                            
        }

        public Employee Delete(int id)
        {
            var employee = employees.SingleOrDefault(e => e.ID == id);

            if (employee != null)
            {
                employees.Remove(employee);
            }
            return employee;
        }

        public Employee Update(int id, Employee updatedEmployee)
        {
            var employee = employees.SingleOrDefault(e => e.ID == id);
            if (employee != null)
            {
                employee.ID = id;
                employee.LastName = updatedEmployee.LastName;
                employee.FirstName = updatedEmployee.FirstName;
                employee.HireDate = updatedEmployee.HireDate;
            }
            return employee;
        }

        public int Commit()
        {
            return 1;
        }

        public IQueryable<Employee> GetAllQuery()
        {
            return employees.AsQueryable();
        }
    }
}
