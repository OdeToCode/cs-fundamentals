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
            var fileGreetingService = new FileGreetingService("output.txt");
            var employee = new Employee(1, "Scott", fileGreetingService);
            var customer = new Customer("Allen", fileGreetingService);

            Speak(employee);
            Speak(customer);
        }

        static void Speak(Human human)
        {
            human.SayHello();
        }
    }
}
