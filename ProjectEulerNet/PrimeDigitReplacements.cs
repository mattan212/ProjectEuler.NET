using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace ProjectEulerNet
{
    public class PrimeDigitReplacements
    {
        public static int Solve(int numberOfDigits, int familySize)
        {
            var primes = JsonConvert.DeserializeObject<List<int>>(File.ReadAllText(Path.Combine("DataFiles", "PrimesTo1M.json")));

            var familySet = primes.Where(x => x < Math.Pow(10, numberOfDigits) && x > Math.Pow(10, numberOfDigits - 1)).ToList();

            var res = GetSet(familySet, familySize);
            if (res != null)
            {
                return int.Parse(res.First());
            }

            return -1;
        }

        private static List<string> GetSet(List<int> familySet, int target)
        {
            var options = new List<int>();

            for (var i = 1; i < Math.Pow(2, familySet.First().ToString().Length) - 1; i++)
            {
                options.Add(i);
            }

            var asStr = familySet.Select(x => x.ToString()).ToList();
            var skip = new HashSet<string>();
            foreach (var prime in asStr)
            {
                if (skip.Contains(prime))
                {
                    continue;
                }
                foreach (var option in options)
                {
                    var list = new List<string>();
                    var regex = GetRegex(prime, option);
                    for (var i = 0; i < 10; i++)
                    {
                        var current = regex.Replace("*", i.ToString());
                        if (asStr.Contains(current))
                        {
                            skip.Add(current);
                            list.Add(current);
                        }
                    }

                    if (list.Count == target)
                    {
                        return list;
                    }
                }
            }

            return null;
        }

        private static readonly string AnyNumber = "*";
        private static string GetRegex(string str, int option)
        {
            var index = str.Length - 1;
            var temp = "";

            while (index >= 0)
            {
                if (option % 2 == 1)
                {
                    temp = AnyNumber + temp;
                }
                else
                {
                    temp = str[index] + temp;
                }

                index--;
                option /= 2;
            }

            return temp;
        }
    }
}
