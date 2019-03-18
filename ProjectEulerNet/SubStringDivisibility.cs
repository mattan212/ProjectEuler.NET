using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerNet
{
    public class SubStringDivisibility
    {
        public static long Solve()
        {
            Insert("", new bool[10]);

            long res = 0;

            foreach (var candidate in _options)
            {
                if ((int.Parse(candidate.Substring(1, 3)) % 2 == 0) &&
                    (int.Parse(candidate.Substring(2, 3)) % 3 == 0) &&
                    (int.Parse(candidate.Substring(3, 3)) % 5 == 0) &&
                    (int.Parse(candidate.Substring(4, 3)) % 7 == 0) &&
                    (int.Parse(candidate.Substring(5, 3)) % 11 == 0) &&
                    (int.Parse(candidate.Substring(6, 3)) % 13 == 0) &&
                    (int.Parse(candidate.Substring(7, 3)) % 17 == 0))
                {
                    res += long.Parse(candidate);
                }
            }

            return res;
        }

        public static List<string> _options = new List<string>();

        private static void Insert(string aggregate, bool[] options)
        {
            if (options.All(x => x == true))
            {
                _options.Add(aggregate);
                return;
            }

            for (var i = 0; i < options.Length; i++)
            {
                if (options[i] == false)
                {
                    options[i] = true;
                    Insert(aggregate + i, options);
                    options[i] = false;
                }
            }
        }
    }
}
