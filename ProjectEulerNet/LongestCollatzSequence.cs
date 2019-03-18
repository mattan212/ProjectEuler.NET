using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerNet
{
    public class LongestCollatzSequence
    {
        private static Dictionary<long, int> _cache = new Dictionary<long, int>
        {
            {1, 0},
            {2, 1}
        };

        public static int Solve(int cutoffNumber)
        {
            int max = 0;
            long collatzNumber = 1;

            for (var i = cutoffNumber - 1; i > cutoffNumber / 3; i--)
            {
                if (_cache.ContainsKey(i))
                {
                    continue;
                }

                var current = CollatzNumber(i);
                if (current > max)
                {
                    collatzNumber = i;
                    max = current;
                }
            }

            return (int)collatzNumber;
        }

        private static int CollatzNumber(long n)
        {
            if (_cache.ContainsKey(n))
            {
                return _cache[n];
            }

            var res = 1 + (n % 2 == 0 ? CollatzNumber(n / 2) : CollatzNumber(n * 3 + 1));

            if (n < 1_000_000)
            {
                _cache.Add(n, res);
            }

            return res;
        }
    }
}
