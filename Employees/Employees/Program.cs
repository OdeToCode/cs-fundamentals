using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Core;
using System.Linq;

namespace Employees
{
    class Program
    {

        static void Main(string[] args)
        {

            var files2 = Directory.GetFiles(@"c:\temp")
                         .Select(f => new FileInfo(f))
                         .OrderByDescending(info => info.Length)
                         .Where(f => f.CreationTime > new DateTime(2010, 1, 1))
                         .Select(f => new { f.Name, f.Length, f.CreationTime });

            var files = from fileName in Directory.GetFiles(@"c:\temp")
                        select new FileInfo(fileName) into attributes
                        orderby attributes.Length descending
                        where attributes.CreationTime > new DateTime(2010, 1, 1)
                        select new
                        {
                            attributes.Name,
                            attributes.Length,
                            attributes.CreationTime
                        };
            foreach (var file in files)
            {
                Console.WriteLine($"{file.Name} {file.Length:N0} : {file.CreationTime.Year}");
            }


            foreach (var file in files)
            {
                Console.WriteLine(file);
            }






            var numberMap = new Dictionary<int, string>()
            {
                { 3, "three" },
                { 4, "four"  }
            };
            numberMap.Add(1, "one");
            numberMap.Add(2, "two");

            var value = numberMap[2];

            foreach(var kvp in numberMap)
            {
                Console.WriteLine($"{kvp.Key}:{kvp.Value}");
            }

            //var numbers = new Queue<int>();
            //numbers.Enqueue(1);
            //numbers.Enqueue(4);
            //numbers.Enqueue(7);

            var numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(4);
            numbers.Push(7);


            var enumerator = numbers.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }

           





     
     
        }

     
    }
}
