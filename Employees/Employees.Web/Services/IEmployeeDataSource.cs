using Employees.Web.Entities;
using System.Collections.Generic;
namespace Employees.Web.Services
{
    public interface IEmployeeDataSource
    {
        IEnumerable<Employee> GetAll();
        Employee Get(int id);
        Employee Add(Employee newEmployee);
        Employee Update(int id, Employee updatedEmployee);
        Employee Delete(int id);
        int Commit();
    }
}
