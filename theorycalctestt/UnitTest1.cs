using System;
using Xunit;
using theorycalctestt;

namespace theorycalctestt
{
    public class UnitTest1
    {

        [Fact]
        public void Fact()
        {
            Calculator calc = new Calculator();

            Assert.Equal(4, calc.Add(2,2));
        }

        [Theory]
        [InlineData(5, 2, 3)]
        [InlineData(10, 5, 5)]
        [InlineData(8, 1, 0)]
        public void Theory(int expected, int numA, int numB)
        {
            Calculator calc = new Calculator();

            Assert.Equal(expected, calc.Add(numA, numB));
        }


    }
}
