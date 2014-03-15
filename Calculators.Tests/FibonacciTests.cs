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
        [Test]
        public void CanCalculateFibonacciValueForZero()
        {
            int result = FibonacciCalculator.Calculate(0);

            Assert.AreEqual(0, result);
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
