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
        [TestCase(CalculatorType.Fibonacci, typeof(FibonacciCalculator))]
        [TestCase(CalculatorType.Squaring, typeof(SquaringCalculator))]
        public void CanGetInstanceOfCalculator(CalculatorType calcTypeEnum, Type expectedType)
        {
            IOrdinalCalculator calculator = CalculatorFactory.GetInstanceOf(calcTypeEnum);

            Assert.IsNotNull(calculator);
            Assert.IsInstanceOf(expectedType, calculator);
        }
    }
}
