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
        public void CanCalculateFibonacciValueFor(int n, int expectedValue)
        {
            int result = FibonacciCalculator.Calculate(n);

            Assert.AreEqual(expectedValue, result);
        }

        //TODO: this next is for n=1 but is pretty much the same in structure as the previous one.
        //May need to refactor it to remove duplication!

        [Test]
        public void CanCalculateFibonacciValueForOne()
        {
            int result = FibonacciCalculator.Calculate(1);

            Assert.AreEqual(1, result);
        }

    }
}
