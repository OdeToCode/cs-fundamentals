using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Employees.Web.Services;
using Microsoft.Extensions.Logging;

namespace Employees.Web.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class GreetingController : ControllerBase
    {
        private readonly ILogger<GreetingController> logger;
        private readonly IGreetingService greetingService;

        public GreetingController(
            ILogger<GreetingController> logger,
            IGreetingService greetingService)
        {
            this.logger = logger;
            this.greetingService = greetingService;
        }

        [HttpGet]
        [Route("message/{name}")]
        public string Get(string name)
        {
            logger.LogCritical($"Executing Get in {nameof(GreetingController)}");
            return greetingService.GetMessage() + $", {name}";
        }
    }
}