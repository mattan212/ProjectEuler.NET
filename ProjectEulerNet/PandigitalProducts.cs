using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerNet
{
    public class PandigitalProducts
    {
        public static int Solve(int n)
        {
            var options = new bool[n]; //options will be used to indicate available and used characters. n - 1 because we're starting from 1.

            Insert("", options);

            var products = new HashSet<int>();

            foreach (var option in _options)
            {
                for (var multiplyIndex = 1; multiplyIndex < option.Length - 2; multiplyIndex++)
                {
                    for (var equalityIndex = multiplyIndex + 2; equalityIndex < option.Length - 1; equalityIndex++)
                    {
                        var left = int.Parse(option.Substring(0, multiplyIndex));
                        var right = int.Parse(option.Substring(multiplyIndex, equalityIndex - multiplyIndex));
                        var sum = int.Parse(option.Substring(equalityIndex));

                        if (left * right == sum)
                        {
                            products.Add(sum);
                        }
                        else if (left * right > sum)
                        {
                            break;
                        }
                    }
                }
            }

            return products.Sum();
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
                    Insert(aggregate + (i + 1), options);
                    options[i] = false;
                }
            }
        }
    }
}
