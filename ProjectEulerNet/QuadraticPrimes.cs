using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using ProjectEulerNet.Helpers;

namespace ProjectEulerNet
{
    public class QuadraticPrimes
    {
        public static int Solve(int limit)
        {
            var max = 0;
            var res = 0;

            for (var i = -1 * limit; i <= limit; i++)
            {
                for (var j = -1 * limit; j <= limit; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        continue;
                    }

                    var current = ConsecutivePrimeNumbers(i, j);
                    if (current > max)
                    {
                        max = current;
                        res = i * j;
                    }
                }
            }
            
            return res;
        }

        public static int ConsecutivePrimeNumbers(int a, int b)
        {
            var res = 0;
            var i = 0;
            while (true)
            {
                var current = (i * i) + (i * a) + b;
                if (!PrimeNumbers.IsPrime(current))
                {
                    return res;
                }

                i++;
                res++;
            }
        }
    }
}
