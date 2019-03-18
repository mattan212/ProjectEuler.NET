using System;
using System.Collections.Generic;
using System.Text;
using ProjectEulerNet.Helpers;

namespace ProjectEulerNet
{
    public class DistinctPowers
    {
        public static int Solve(int n)
        {
            var set = new HashSet<string>();

            for (var i = 2; i <= n; i++)
            {
                var current = i.ToString();
                for (var j = 2; j <= n; j++)
                {
                    current = current.Multiply(i);
                    set.Add(current);
                }
            }

            return set.Count;
        }
    }
}
