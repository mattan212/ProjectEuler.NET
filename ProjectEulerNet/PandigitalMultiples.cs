using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerNet
{
    public class PandigitalMultiples
    {
        public static int Solve()
        {
            var max = -1;
            for (var i = 2; i < 50_000; i++)
            {
                var current = GetMaxPandigitalMultiple(i);
                if (current > max)
                {
                    max = current;
                }
            }

            return max;
        }

        private static int GetMaxPandigitalMultiple(int num)
        {
            var current = "";
            for (var i = 1;; i++)
            {
                if (current.Length > 9 || current.Contains('0'))
                {
                    break;
                }
                current += (num * i);

                if (current.Length == 9 && current.Distinct().Count(x => x != '0') == 9)
                {
                    return int.Parse(current);
                }
            }

            return -1;
        }
    }
}
