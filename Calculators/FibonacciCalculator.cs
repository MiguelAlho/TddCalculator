﻿using System;
using Calculators.Interfaces;

namespace Calculators
{
    public class FibonacciCalculator : IOrdinalCalculator
    {
        public const string NEGATIVE_ORDINAL_ERRMSG = "Can only calculate Fibonaci values for positive integers.";

        public int Calculate(int n)
        {
            if(n<0)
                throw new ArgumentOutOfRangeException("n", NEGATIVE_ORDINAL_ERRMSG);

             if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            return Calculate(n - 1) + Calculate(n - 2);
        }
    }
}
