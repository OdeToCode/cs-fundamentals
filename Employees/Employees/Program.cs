using System;
using Core;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            var greetingService = new GreetingService();
            var redGreetingService = new RedGreetingService();
            var employee = new Employee(1, "Scott", greetingService);
            var customer = new Customer("Allen", redGreetingService);

            Speak(employee);
            Speak(customer);
        }

        static void Speak(Human human)
        {
            human.SayHello();
        }
    }
}
