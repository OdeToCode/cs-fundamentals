using System;

namespace Employees
{
    class Program
    {
        static int Main(string[] args)
        {
            var name = "Default";

            if (args.Length > 0)
            {
                name = args[0];
            }

            SayHello(name);

            return 1;
        }

        private static void SayHello(string name)
        {
            var hour = DateTime.UtcNow.Hour;

            if (hour < 12)
            {
                Console.WriteLine($"Good morning, {name}!");
            }
            else if (hour <= 17)
            {
                Console.WriteLine($"Good afternoon, {name}!");
            }
            else
            {
                Console.WriteLine($"Good evening {name}!");
            }
        }
    }
}
