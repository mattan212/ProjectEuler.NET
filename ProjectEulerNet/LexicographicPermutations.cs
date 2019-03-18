using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerNet
{
    public class LexicographicPermutations
    {
        public static string Solve(int n, int index)
        {
            var options = new bool[n]; //options will be used to indicate available and used characters.

            Insert("", options);
            
            return _options[index];
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
