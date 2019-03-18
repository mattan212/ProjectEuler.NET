using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerNet
{
    /// <summary>
    /// https://projecteuler.net/problem=1
    /// </summary>
    public class MultiplesOf3And5
    {
        public static int Solve(int n)
        {
            var sum = 0;
            
            for (var i = 3; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
