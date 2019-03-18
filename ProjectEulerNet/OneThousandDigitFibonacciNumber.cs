using System;
using System.Collections.Generic;
using System.Text;
using ProjectEulerNet.Helpers;

namespace ProjectEulerNet
{
    public class OneThousandDigitFibonacciNumber
    {
        public static int Solve(int digitCount)
        {
            var current = "1";
            var index = 1;

            while (current.Length < digitCount)
            {
                current = Fib(index++);
            }

            return index - 1;
        }

        private static List<string> _cache = new List<string>();

        private static string Fib(int n)
        {
            if (n <= 2)
            {
                return "1";
            }

            if (_cache.Count > n)
            {
                return _cache[n];
            }

            var res = Fib(n - 1).Add(Fib(n - 2));

            _cache.Add(res);

            return res;
        }
    }
}
