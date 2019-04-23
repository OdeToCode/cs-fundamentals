using System;
using Core;
using Xunit;

namespace UnitsTests
{
    public class ReferenceTypeBehavior
    {
        [Fact]
        public void StringsBehaveLikeValueTypes()
        {
            string name = "Scott";

            var rightNow = DateTime.UtcNow;

            name = UppercaseString(name);

            Assert.Equal("SCOTT", name);
        }

        private string UppercaseString(string param)
        {
            return param.ToUpper();
        }


        [Fact]
        public void ReferenceTypesPassToMethodsAsValue()
        {
            var employee = new Employee(1, "Scott", new GreetingService());
            SetName(employee);

            Assert.Equal("ALLEN", employee.Name);
        }

        private void SetName(Employee employee)
        {
           employee.Name = "Allen";
        }

        [Fact]
        public void ValueTypesPassToMethodsAsValueTypes()
        {
            int x = 3;

            SetX(x);

            Assert.Equal(3, x);
        }

        private void SetX(int x)
        {
            x = 10;
        }

        [Fact]
        public void TwoVariablesCanReferToSameObject()
        {
            Employee e1 = new Employee(1, "Scott", new GreetingService());
            Employee e2 = e1;

            e1.Name = "Allen";

            Assert.True(object.ReferenceEquals(e1, e2));
            Assert.Equal("ALLEN", e2.Name);
        }
    }
}
