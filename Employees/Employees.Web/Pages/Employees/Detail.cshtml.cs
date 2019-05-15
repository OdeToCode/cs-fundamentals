using Employees.Web.Entities;
using Employees.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Employees.Web.Pages.Employees
{
    public class DetailModel : PageModel
    {
        private readonly IEmployeeDataSource employeeDataSource;
        public Employee Employee { get; set; }

        public DetailModel(IEmployeeDataSource employeeDataSource)
        {
            this.employeeDataSource = employeeDataSource;
        }


        public IActionResult OnGet(int employeeId)
        {
            Employee = employeeDataSource.Get(employeeId);
            if(Employee == null)
            {
                return RedirectToPage("NotFound");
            }
            return Page();
        }
    }
}