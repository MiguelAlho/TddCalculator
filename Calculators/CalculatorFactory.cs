using Calculators.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    public class CalculatorFactory
    {
        public static IOrdinalCalculator GetInstanceOf(CalculatorType calculatorType)
        {
            IOrdinalCalculator calculator = null;

            switch (calculatorType)
            {
                case CalculatorType.Fibonacci:
                    calculator = new FibonacciCalculator();
                    break;
                case CalculatorType.Squaring:
                    calculator = new SquaringCalculator();
                    break;
            }

            return calculator;
        }
    }
}
