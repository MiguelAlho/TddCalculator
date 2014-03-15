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
        public void CanCalculateFibonaciValueForZero()
        {
            int result = FibonacciCalculator.Calculate(0);

            Assert.AreEqual(0, result);
        }

    }
}
