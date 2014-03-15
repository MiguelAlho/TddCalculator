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
            IOrdinalCalculator calculator = CalculatorFactory.GetInstanceOf(CalculatorType.Fibonaci);

            Assert.IsNotNull(calculator);
            Assert.IsInstanceOf<FibonacciCalculator>(calculator);
        }
    }
}
