using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerNet
{
    public class NonAbundantSums
    {
        public static long Solve(int upperLimit)
        {
            var abundantNumbers = new List<int>();

            var abundantNumbersSums = new HashSet<int>();

            for (var i = 0; i < upperLimit; i++)
            {
                if (IsAbundant(i))
                {
                    abundantNumbers.Add(i);
                }
            }

            for (var i = 0; i < abundantNumbers.Count; i++)
            {
                for (var j = i; j < abundantNumbers.Count; j++)
                {
                    abundantNumbersSums.Add(abundantNumbers[i] + abundantNumbers[j]);
                }
            }

            var res = 0;
            for (var i = 0; i < upperLimit; i++)
            {
                if (!abundantNumbersSums.Contains(i))
                {
                    res += i;
                }
            }

            return res;
        }

        private static bool IsAbundant(int num)
        {
            return GetDivisorsSum(num) > num;
        }

        private static int GetDivisorsSum(int num)
        {
            var res = 0;

            for (var i = 1; i <= (num / 2); i++)
            {
                if (num % i == 0)
                {
                    res += i;
                }
            }

            return res;
        }
    }
}
