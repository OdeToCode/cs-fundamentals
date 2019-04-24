using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace Employees.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration configuration;

        public string Greeting { get; set; }

        public IndexModel(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public void OnGet()
        {
            Greeting = configuration["Greeting"];
        }
    }
}
