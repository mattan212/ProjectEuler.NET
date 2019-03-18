using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerNet
{
    /// <summary>
    /// https://projecteuler.net/problem=6
    /// </summary>
    public class SumSquareDifference
    {
        public static long Solve(int n)
        {
            long squareSum = 0;

            long squareTotal = 0;

            for (var i = 1; i <= n; i++)
            {
                squareSum += (int)Math.Pow(i, 2);

                squareTotal += i;
            }

            return (long)(Math.Pow(squareTotal, 2) - squareSum);
        }
    }
}
