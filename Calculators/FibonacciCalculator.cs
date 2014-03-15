using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculators
{
    public class FibonacciCalculator
    {
        public static int Calculate(int n)
        {
            //TODO: do we need to treat n<0 ????

            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            return Calculate(n - 1) + Calculate(n - 2);
        }
    }
}
