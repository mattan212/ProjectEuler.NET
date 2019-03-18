using System;
using System.Collections.Generic;
using System.Text;
using ProjectEulerNet.Helpers;

namespace ProjectEulerNet
{
    public class PowerDigitSum
    {
        public static long Solve(int n)
        {
            string total = "1";
            for (var i = 0; i < n; i++)
            {
                total = total.Add(total);
            }

            long res = 0;
            foreach (var c in total)
            {
                res += c - '0';
            }

            return res;
        }
    }
}
