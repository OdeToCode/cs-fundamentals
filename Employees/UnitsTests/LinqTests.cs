using Xunit;
using System.Linq;
using System.Collections.Generic;
using Core;

namespace UnitsTests
{
    public class LinqTests
    {
        [Fact]
        public void LinqCanQueryLists()
        {
            var department = GetDepartmentEmployees();

            //var aEmployees = department.Where(e => e.Name.Contains('a'));

            var baseQuery = (from e in department
                             where e.Id > 0
                             orderby e.Id
                             select e).ToList();

            var nameSorted = from e in baseQuery
                             orderby e.Name
                             select e;

            var aEmployees = from e in nameSorted
                             where e.Name.Contains('a')
                             orderby e.Id descending
                             select e;

            department.Where(e => e.Name.Contains('a'))
                      .OrderByDescending(e => e.Id)
                      .Select(e => e)
                      .ToList();

            Assert.Equal(2, aEmployees.Count());

        }

        private IEnumerable<Employee> GetDepartmentEmployees()
        {
            yield return new Employee { Id = 1, Name = "Richard" };
            yield return new Employee { Id = 2, Name = "Scott" };
            yield return new Employee { Id = 3, Name = "Daniel" };
        }

        [Fact]
        public void LinqCanQueryArrays()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var result = numbers.Where(n => n % 2 == 1);

            Assert.Equal(5, result.Count());
        }      
    }
}
