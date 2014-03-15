using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators.Tests
{
    [TestFixture]
    public class SquaringCalculatorTests
    {
        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(5, 25)]
        [TestCase(-5, 25)]
        public void CanCalculateSquareOf(int n, int expectedResult)
        {
            int result = SquaringCalculator.CalculateFor(n);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
