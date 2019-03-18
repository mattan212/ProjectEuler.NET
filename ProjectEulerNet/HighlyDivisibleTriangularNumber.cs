using System.Collections.Generic;

namespace ProjectEulerNet
{
    public class HighlyDivisibleTriangularNumber
    {
        public static long Solve(int divisorsCount)
        {
            long current = 1;
            var nthTriangle = 1;

            while (CountDivisors(current) < divisorsCount)
            {
                current = GetTriangleNumber(++nthTriangle);
            }

            return current;
        }

        private static List<long> _cache = new List<long>
        {
            0, 1
        };

        private static int CountDivisors(long number)
        {
            var res = 2; //for 1 and the number itself
            var min = 2;
            var max = number / 2;

            for (var i = min; i < max; i++)
            {
                if (number % i == 0)
                {
                    res += 2;
                    max = number / i;
                }
            }

            return res;
        }

        private static long GetTriangleNumber(int n)
        {
            if (_cache.Count > n)
            {
                return _cache[n];
            }

            var res = GetTriangleNumber(n - 1) + n;

            _cache.Add(res);

            return res;
        }
    }
}
