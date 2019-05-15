using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employees.Web.Entities;
using Employees.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Employees.Web.Pages.Employees
{
    public class EditModel : PageModel
    {
        private readonly IEmployeeDataSource employeeDataSource;

        [BindProperty]
        public Employee Employee { get; set; }

        public EditModel(IEmployeeDataSource employeeDataSource)
        {
            this.employeeDataSource = employeeDataSource;
        }

        public ActionResult OnPost(int employeeId)
        {
            if (ModelState.IsValid)
            {
                employeeDataSource.Update(employeeId, Employee);
                employeeDataSource.Commit();
                TempData["Message"] = $"You have saved the record for {Employee.FirstName}";
                return RedirectToPage("/Index");
            }
            return Page();
           
        }

        public ActionResult OnGet(int employeeId)
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