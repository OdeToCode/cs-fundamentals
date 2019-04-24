using Core;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Xunit;

namespace UnitsTests
{
    //public delegate void LogDelegate(string args);

    public class DelegateTests
    {
        [Fact]
        public void FuncsAreDelegatesThatReturnValues()
        {
            Func<int, int, int> add = (x, y) => x + y;
            Func<int, int> square = x => x * x;
            Func<int> three = () => 3;

            add(three(), three());

            int result = add(3, square(5));
            Assert.Equal(28, result);
        }

        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Square(int x)
        {
            return x * x;
        }

       [Fact]
       public void DelegatesAreMethodVariables()
       {
            //LogDelegate logger = InMemoryLogger;
            Action<string> logger = InMemoryLogger;

            logger("This is a warning!");
            logger("Error code 340o34");

            Assert.Equal(2, messages.Count);
            Assert.Equal("This is a warning!", messages[0]);
       }

        void InMemoryLogger(string message)
        {
            messages.Add(message);
        }

        List<string> messages = new List<string>();
    }
}
