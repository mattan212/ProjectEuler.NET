using System;
using System.Collections.Generic;
using System.Text;
using ProjectEulerNet.Helpers;

namespace ProjectEulerNet
{
    /// <summary>
    /// https://projecteuler.net/problem=3
    /// </summary>
    public class LargestPrimeFactor
    {
        public static int Solve(long num)
        {
            var primes = PrimeNumbers.GetAllPrimes((int)Math.Sqrt(num));

            var res = 1;

            for (var i = primes.Count - 1; i > 1; i--)
            {
                if (num % primes[i] == 0)
                {
                    res = primes[i];
                    break;
                }
            }

            return res;
        }
    }
}
