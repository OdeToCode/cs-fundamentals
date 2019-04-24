using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Employees.Web.Services;

namespace Employees.Web.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        private readonly IGreetingService greetingService;

        public GreetingController(IGreetingService greetingService)
        {
            this.greetingService = greetingService;
        }

        [HttpGet]
        public string Get()
        {
            return greetingService.GetMessage();
        }
    }
}