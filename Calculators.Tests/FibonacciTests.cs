using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators.Tests
{
    [TestFixture]
    public class FibonacciTests
    {
        [TestCase(0,0)]
        [TestCase(1,1)]
        [TestCase(2,1)]
        [TestCase(7, 13)]
        public void CanCalculateFibonacciValueFor(int n, int expectedValue)
        {
            int result = FibonacciCalculator.Calculate(n);

            Assert.AreEqual(expectedValue, result);
        }

        
    }
}
