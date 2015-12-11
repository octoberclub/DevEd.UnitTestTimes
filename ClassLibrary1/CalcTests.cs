using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ClassLibrary1
{
    class CalcTests
    {
        [Test]
        public async Task TestCalculator()
        {
            var sut = new Calculator();
            int result= await sut.Divide(10, 2);
            Assert.That(result, Is.EqualTo(5));
        }
    }

    internal class Calculator
    {
        public async Task<int> Divide(int  numerator, int denominator)
        {
            //Long processing
            await Task.Delay(100);
            return numerator/denominator;
        }
    }
}
