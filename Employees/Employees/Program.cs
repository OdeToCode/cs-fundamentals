using System;
using System.Collections;
using System.Threading;
using Core;

namespace Employees
{
    class Program
    {
        static IEnumerable GetNames()
        {
            yield return "Scott";
            Thread.Sleep(2000);
            yield return "Alex";
            Thread.Sleep(2000);
            yield return "Alex";
            Thread.Sleep(2000);
            yield return "Alex";
            Thread.Sleep(2000);
            yield return "Alex";
            Thread.Sleep(2000);
        }

        static void Main(string[] args)
        {
            var nameEnumerator = GetNames().GetEnumerator();
            while(nameEnumerator.MoveNext())
            {
                Console.WriteLine(nameEnumerator.Current);
            }

            int[] numbers = new int[] { 1, 2, 3, 4 };

            var enumerator = numbers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}





            var fileGreetingService = new FileGreetingService("output.txt");
            Employee employee = new Employee(1, "Scott", fileGreetingService);
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
