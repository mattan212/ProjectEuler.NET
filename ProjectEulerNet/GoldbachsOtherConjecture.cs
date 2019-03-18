using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEulerNet.Helpers;

namespace ProjectEulerNet
{
    public class GoldbachsOtherConjecture
    {
        public static int Solve(long threshold)
        {
            var res = int.MaxValue;

            var primes = PrimeNumbers.GetAllPrimes(10_000);

            var primesSet = new HashSet<int>();

            primes.ForEach(x => primesSet.Add(x));

            var options = new HashSet<int>();
            var composites = new List<int>();
            for (var i = 1; i < threshold; i++)
            {
                if (i % 2 != 0 && !PrimeNumbers.IsPrime(i) && i > 1)
                {
                    options.Add(i);
                }

                composites.Add(2 * i * i);
            }

            for (var i = 0; i < composites.Count; i++)
            {
                foreach (var prime in primes)
                {
                    options.Remove(composites[i] + prime);
                }
            }

            if (options.Any())
            {
                return options.First();
            }
            throw new Exception($"Couldn't find the exception between 9 to {threshold} ");
        }
    }
}
