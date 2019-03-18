using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerNet
{
    public class DigitFactorials
    {
        static Dictionary<int, int> _facts = new Dictionary<int, int>
        {
            {0, 1},
            {1, 1},
            {2, 2},
            {3, 6},
            {4, 24},
            {5, 120},
            {6, 720},
            {7, 5040},
            {8, 40320},
            {9, 362880},
        };

        public static long Solve()
        {
            var options = new List<int>();
            for (var i = 10; i < 1499999; i++)
            {
                if (i == FactorialSum(i))
                {
                    options.Add(i);
                }
            }

            return options.Sum();
        }

        private static int FactorialSum(int num)
        {
            var acc = 0;
            while (num > 0)
            {
                acc += _facts[num % 10];
                num /= 10;
            }

            return acc;
        }
    }
}
