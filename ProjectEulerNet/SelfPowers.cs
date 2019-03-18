using System;
using System.Collections.Generic;
using System.Text;
using ProjectEulerNet.Helpers;

namespace ProjectEulerNet
{
    public class SelfPowers
    {
        public static long Solve(int n)
        {
            long res = 0;

            long mod = 10_000_000_000;
            for (long i = 1; i <= n; i++)
            {
                res = (res + Pow(i, i, mod)) % mod; 
            }

            return res;
        }

        private static long Pow(long a, long b, long mod)
        {
            long res = 1;

            for (var i = 0; i < b; i++)
            {
                res = res * a % mod;
            }

            return res;
        }
    }
}
