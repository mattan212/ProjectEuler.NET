using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEulerNet.Helpers;

namespace ProjectEulerNet
{
    public class ReciprocalCycles
    {
        public static int Solve(int range)
        {
            var maxCycleSize = 0;
            var res = 0;
            var accuracy = 2000;
            var results = new Dictionary<int, int>();
            var maxCycles = new Dictionary<int, string>();
            var decimals = new Dictionary<int, string>();

            for (int i = 2; i < range; i++)
            {
                string d = i.DivideByOne(accuracy);

                if (d.Length < accuracy)
                {
                    continue;
                }

                if (i > 100)
                {

                }
                var maxCycle = GetMaxCycle(d);

                decimals.Add(i, d);
                maxCycles.Add(i, maxCycle);

                if (maxCycle.Length > 1)
                {
                    results.Add((int)i, maxCycle.Length);
                }

                if (maxCycle.Length > maxCycleSize)
                {
                    res = (int)i;
                    maxCycleSize = maxCycle.Length;
                }
            }
            
            return res;
        }

        private static string GetMaxCycle(string d)
        {
            d = d.Substring(2);

            var options = new Dictionary<int, List<int>>();

            for (var start = 0; start < 6; start++)
            {
                options.Add(start, new List<int>());
                for (var i = start + 1; i < d.Length / 2; i++)
                {
                    if (d[i] == d[start])
                    {
                        options[start].Add(i);
                    }
                }
            }

            var results = new Dictionary<int, string>();

            foreach (var option in options)
            {
                var start = option.Key;
                foreach (var startIndex in option.Value)
                {
                    var current = d.Substring(start, startIndex - start);
                    
                    if (d.Substring(startIndex).StartsWith(current))
                    {
                        results.Add(start, current);
                        break;
                    }
                }
            }

            return results.First(x => x.Value == results.Max(y => y.Value)).Value;
        }
    }
}
