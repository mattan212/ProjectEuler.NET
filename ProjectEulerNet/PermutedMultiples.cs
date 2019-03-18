using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerNet
{
    public class PermutedMultiples
    {
        public static long Solve(int multiMatch)
        {
            var pow = 0;
            var res = -1;
            for (long i = 1; i < int.MaxValue; i++)
            {
                var success = true;
                for (var j = 2; j <= multiMatch; j++)
                {
                    var current = i * j;
                    if (("" + current).Length > ("" + i).Length)
                    {
                        i = (long)Math.Pow(10, pow++);
                        success = false;
                        break;
                    }

                    if (!IsPerm(current, i))
                    {
                        success = false;
                        break;
                    }
                }

                if (success)
                {
                    res = (int)i;
                    break;
                }
            }

            return res;
        }

        private static bool IsPerm(long current, long i)
        {
            var asStr1 = current.ToString();
            var asStr2 = i.ToString();
            if (asStr1.Length != asStr2.Length)
            {
                return false;
            }

            var dict = new Dictionary<char, int>();

            foreach (var c in asStr1)
            {
                dict[c] = dict.ContainsKey(c) ? dict[c] + 1 : 1;
            }

            foreach (var c in asStr2)
            {
                if (!dict.ContainsKey(c) || dict[c] <= 0)
                {
                    return false;
                }

                dict[c]--;
            }

            return true;
        }
    }
}
