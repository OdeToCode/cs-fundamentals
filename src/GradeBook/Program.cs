using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {          
            var numbers = new double[10];
            numbers[0] = 12.7;

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
