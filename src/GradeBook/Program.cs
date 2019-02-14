using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {          
            var numbers = new[] { 12.7, 10.3, 6.11, 4.1 };

            var result = numbers[0];
            result += numbers[1];
            result += numbers[2];
            Console.WriteLine(result);

            if(args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
            }
            else 
            {
                Console.WriteLine("Hello!");
            }
        }        
    }
}
