using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEulerNet.Helpers;

namespace ProjectEulerNet
{
    public class DigitFifthPowers
    {
        public static int Solve(int powerOf)
        {
            var res = 0;
            for (var i = 10; i < 1000000; i++)
            {
                var sumOfDigitPows = (int)i.Digits().Sum(x => Math.Pow(x, powerOf));

                if (i == sumOfDigitPows)
                {
                    res += i;
                }
            }

            return res;
        }
    }
}
