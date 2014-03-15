using Calculators.Interfaces;
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
        [Test]
        public void CanCreateInstanceOfSquaringCalculator()
        {
            var instance = new SquaringCalculator();

            Assert.IsNotNull(instance);
            Assert.IsInstanceOf<SquaringCalculator>(instance);
            Assert.IsInstanceOf<IOrdinalCalculator>(instance);
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(5, 25)]
        [TestCase(-5, 25)]
        public void CanCalculateForSquareOf(int n, int expectedResult)
        {
            int result = SquaringCalculator.CalculateFor(n);

            Assert.AreEqual(expectedResult, result);
        }

        [TestCase(0, 0)]
        [TestCase(1, 1)]
        [TestCase(5, 25)]
        [TestCase(-5, 25)]
        public void CanCalculateSquareOf(int n, int expectedResult)
        {
            IOrdinalCalculator calculator = new SquaringCalculator();

            int result = calculator.Calculate(n);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
