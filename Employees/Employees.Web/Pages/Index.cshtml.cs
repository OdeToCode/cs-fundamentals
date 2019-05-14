using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employees.Web.Entities;
using Employees.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Employees.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IGreetingService configuration;
        private readonly IEmployeeDataSource employeeDataSource;

        public string Greeting { get; set; }
        public int EmployeeCount { get; set; }
        public IList<Employee> Employees { get; set; }


        public IndexModel(IGreetingService configuration, 
                         IEmployeeDataSource employeeDataSource)
        {
            this.configuration = configuration;
            this.employeeDataSource = employeeDataSource;
        }

        public void OnGet()
        {
            Greeting = configuration.GetMessage().ToLower();
            Employees = employeeDataSource.GetAll().ToList();
        }
    }
}
