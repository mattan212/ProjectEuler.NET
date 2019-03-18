using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerNet
{
    public class AmicableNumbers
    {
        public static int Solve(int n)
        {
            Dictionary<int, int> divisorsSum = new Dictionary<int, int>();

            for (var i = 0; i < n; i++)
            {
                divisorsSum.Add(i, GetDivisorsSum(i));
            }

            var res = 0;

            for (var i = 0; i < n; i++)
            {
                if (IsAmicable(i, divisorsSum))
                {
                    res += i;
                }
            }

            return res;
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

        private static bool IsAmicable(int num, Dictionary<int, int> divisorsSum)
        {
            var sum = divisorsSum[num];

            if (!divisorsSum.ContainsKey(sum))
            {
                divisorsSum.Add(sum, GetDivisorsSum(sum));
            }

            return divisorsSum[sum] == num && sum != num;
        }
    }
}
