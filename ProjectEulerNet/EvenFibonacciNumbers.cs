using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerNet
{
    /// <summary>
    /// https://projecteuler.net/problem=2
    /// </summary>
    public class EvenFibonacciNumbers
    {
        private static int[] _cache = new int[1000];
        private static int _max = 0;

        public static int Solve(int cutoff)
        {
            _cache[0] = 1;
            _cache[1] = 1;

            var n = 10;
            while (_max < cutoff)
            {
                n++;
                Fib(n);
            }

            var sum = 0;

            foreach (var v in _cache)
            {
                if (v >= cutoff)
                {
                    break;
                }

                if (v % 2 == 0)
                {
                    sum += v;
                }
            }

            return sum;
        }

        private static int Fib(int n)
        {
            if (_cache[n] != 0)
            {
                return _cache[n];
            }

            var res = Fib(n - 1) + Fib(n - 2);

            _cache[n] = res;

            _max = res;

            return res;
        }
    }
}
