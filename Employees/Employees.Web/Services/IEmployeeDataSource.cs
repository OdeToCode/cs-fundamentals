using Employees.Web.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Employees.Web.Services
{
    public interface IEmployeeDataSource
    {
        IEnumerable<Employee> GetAll();

        IQueryable<Employee> GetAllQuery();

        Employee Get(int id);
        Employee Add(Employee newEmployee);
        Employee Update(int id, Employee updatedEmployee);
        Employee Delete(int id);
        int Commit();
    }
}
