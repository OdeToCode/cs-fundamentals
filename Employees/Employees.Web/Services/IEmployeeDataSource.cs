using Employees.Web.Entities;
using System.Collections.Generic;
namespace Employees.Web.Services
{
    public interface IEmployeeDataSource
    {
        IEnumerable<Employee> GetAll();
        Employee Get(int id);
        Employee Add(Employee newEmployee);
        Employee Update(Employee updatedEmployee);
        Employee Delete(int id);
    }
}
