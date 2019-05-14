using Microsoft.Extensions.Configuration;

namespace Employees.Web.Services
{
    public interface IGreetingService
    {
        string GetMessage();
    }

    public class ConfigBasedGreetingService : IGreetingService
    {
        private readonly IConfiguration configuration;

        public ConfigBasedGreetingService(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public string GetMessage()
        {
            return configuration["Greeting"];
        }
    }
}
