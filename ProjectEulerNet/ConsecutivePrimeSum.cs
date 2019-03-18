using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using ProjectEulerNet.Helpers;

namespace ProjectEulerNet
{
    public class ConsecutivePrimeSum
    {
        public static long Solve(int upperboundThreshold)
        {
            var primes = new List<int>();
            var primesSet = new HashSet<int>();
            for (var i = 2; i < upperboundThreshold; i++)
            {
                if (PrimeNumbers.IsPrime(i))
                {
                    primesSet.Add(i);
                    primes.Add(i);
                }
            }

            var start = primes.Count - 1;

            var currentPrime = primes[start];
            var max = 0;
            var res = 0;
            for (var j = start - 1; j >= 0; j--)
            {
                var currentSum = 0;

                for (var k = j; k >= 0 && currentSum <= currentPrime; k--)
                {
                    currentSum += primes[k];
                    if (j - k > max)
                    {
                        max = j - k;
                        if (primesSet.Contains(currentSum))
                        {
                            res = currentSum;
                        }
                    }
                }
            }

            return res;
        }
    }
}
