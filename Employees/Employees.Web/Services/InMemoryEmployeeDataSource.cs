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
            throw new NotImplementedException();
        }

        public Employee Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            return employees.OrderByDescending(e => e.HireDate.Year);
        }

        public Employee Get(int id)
        {
            return employees.SingleOrDefault(e => e.ID == id);                            
        }

        public Employee Update(Employee updatedEmployee)
        {
            throw new NotImplementedException();
        }
    }
}
