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
        public void CanCreateInstanceOfFibonacciCalculator()
        {
            var instance = new FibonacciCalculator();

            Assert.IsNotNull(instance);
            Assert.IsInstanceOf<IOrdinalCalculator>(instance);
            Assert.IsInstanceOf<FibonacciCalculator>(instance);
        }


        [TestCase(0,0)]
        [TestCase(1,1)]
        [TestCase(2,1)]
        [TestCase(7, 13)]
        public void CanCalculateFibonacciValueFor(int n, int expectedValue)
        {
            int result = FibonacciCalculator.Calculate(n);

            Assert.AreEqual(expectedValue, result);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException), 
            ExpectedMessage= FibonacciCalculator.NEGATIVE_ORDINAL_ERRMSG,      
            MatchType =  MessageMatch.Regex)]
        public void ShouldThrowExceptionForNLessThanZero()
        {
            FibonacciCalculator.Calculate(-1);
        }
        
    }
}
