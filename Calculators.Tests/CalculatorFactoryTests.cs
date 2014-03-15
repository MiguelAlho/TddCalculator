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
    public class CalculatorFactoryTests
    {
        [Test]
        public void CanGetInstanceOfFibonacciCalculator()
        {
            IOrdinalCalculator calculator = CalculatorFactory.GetInstanceOf(CalculatorType.Fibonacci);

            Assert.IsNotNull(calculator);
            Assert.IsInstanceOf<FibonacciCalculator>(calculator);
        }

        [Test]
        public void CanGetInstanceOfSquaringCalculator()
        {
            IOrdinalCalculator calculator = CalculatorFactory.GetInstanceOf(CalculatorType.Squaring);

            Assert.IsNotNull(calculator);
            Assert.IsInstanceOf<SquaringCalculator>(calculator);
        }
    }
}
