using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEulerNet.Helpers;

namespace ProjectEulerNet
{
    public class PandigitalPrime
    {
        public static int Solve()
        {
            for (var i = 9; i > 1; i--)
            {
                _options = new List<string>();
                Insert("", new bool[i]);

                foreach (var candidate in _options.OrderByDescending(x => x))
                {
                    var asInt = int.Parse(candidate);
                    if (PrimeNumbers.IsPrime(asInt))
                    {
                        return asInt;
                    }
                }
            }

            return -1;
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
