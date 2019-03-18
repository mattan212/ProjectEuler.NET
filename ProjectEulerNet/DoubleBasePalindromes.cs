using System;
using System.Collections.Generic;
using System.Text;
using ProjectEulerNet.Helpers;

namespace ProjectEulerNet
{
    public class DoubleBasePalindromes
    {
        public static int Solve(int upperboundLimit)
        {
            var res = 0;

            for (var i = 0; i < upperboundLimit; i++)
            {
                if (i.ToString().IsPalindrome() && ConvertToBase2(i).IsPalindrome())
                {
                    res += i;
                }
            }

            return res;
        }

        private static string ConvertToBase2(int num)
        {
            var res = "";
            while (num > 0)
            {
                res = (num % 2 == 0 ? '0' : '1') + res;
                num /= 2;
            }

            return res;
        }
    }
}
