using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculators.Interfaces;

namespace Calculators
{
    public class SquaringCalculator : IOrdinalCalculator
    {
        public static int CalculateFor(int n)
        {
            return n*n;
        }

        public int Calculate(int n)
        {
            return CalculateFor(n);
        }
    }
}
