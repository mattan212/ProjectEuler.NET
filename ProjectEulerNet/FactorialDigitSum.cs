using System;
using System.Collections.Generic;
using System.Text;
using ProjectEulerNet.Helpers;

namespace ProjectEulerNet
{
    public class FactorialDigitSum
    {
        public static int Solve(int n)
        {
            var total = "1";

            total = Factorial(total, n);
            
            return total.AggregateDigits();
        }

        public static string Factorial(string current, int n)
        {
            if (n == 1)
            {
                return "1";
            }

            return Factorial(current, n - 1).Multiply(n);
        }
    }
}
