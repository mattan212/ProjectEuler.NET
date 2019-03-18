using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEulerNet.Helpers;

namespace ProjectEulerNet
{
    /// <summary>
    /// https://projecteuler.net/problem=7
    /// </summary>
    public class _10001stPrime
    {
        private static List<int> _primes = new List<int>
        {
            2, 3, 5
        };

        public static int Solve(int n)
        {
            var count = 3;
            var current = 6;
            while (count < n)
            {
                current++;

                if (IsPrime(current))
                {
                    _primes.Add(current);
                    count++;
                }
            }

            return current;
        }

        private static bool IsPrime(int num)
        {
            var cutoff = Math.Sqrt(num);
            foreach (var p in _primes)
            {
                if (num % p == 0)
                {
                    return false;
                }

                if (p > cutoff)
                {
                    return true;
                }
            }

            return true;
        }
    }
}
