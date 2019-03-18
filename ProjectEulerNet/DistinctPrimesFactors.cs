using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEulerNet.Helpers;

namespace ProjectEulerNet
{
    public class DistinctPrimesFactors
    {
        public static int Solve(int n) // n indicates how many consecutive number are required.
        {
            var upperboundLimit = 1000000;

            var limit = (int) (Math.Pow(n, 2));
            for (var i = 2; i < upperboundLimit; i++)
            { 
                var set = new HashSet<int>();
                for (var j = 0; j < n; j++)
                {
                    GetPrimeFactors(i + j, limit).ForEach(x => set.Add(x));
                }

                if (set.Count == limit)
                {
                    return i;
                }
            }

            return -1;
        }

        private static List<int> GetPrimeFactors(int num, int limit)
        {
            var res = new List<int>();
            foreach (var prime in PrimeNumbers.GetAllPrimes())
            {
                if (prime > num / 2)
                {
                    break;
                }

                var pow = 0;
                var temp = num;
                while (temp % prime == 0)
                {
                    temp /= prime;
                    pow++;
                }

                if (pow > 0)
                {
                    res.Add((int)(Math.Pow(prime, pow)));
                    if (res.Count >= limit)
                    {
                        break;
                    }
                }
            }

            return res;
        }
    }
}
