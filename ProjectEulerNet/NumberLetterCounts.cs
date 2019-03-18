using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerNet
{
    public class NumberLetterCounts
    {
        public static int Solve(int n)
        {
            var res = 0;
            for (var i = 1; i <= n; i++)
            {
                res += Stringify(i);
            }

            return res;
        }

        public static int Stringify(int num)
        {
            var leadingDigit = GetLeadingDigit(num);
            if (num >= 1000)
            {
                var suffixValue = Stringify(num - (leadingDigit * 1000));
                if (suffixValue > 0)
                {
                    suffixValue += 3; //and ...
                }
                else
                {
                    suffixValue = 0; //we don't count zero
                }
                return Stringify(leadingDigit) + 8 + suffixValue;
            }
            if (num >= 100)
            {
                var suffixValue = Stringify(num - (leadingDigit * 100));
                if (suffixValue > 0)
                {
                    suffixValue += 3; //and ...
                }
                else
                {
                    suffixValue = 0; //we don't count zero
                }
                return Stringify(leadingDigit) + 7 + suffixValue;
            }

            if (num >= 20)
            {
                var prefixValue = 0;
                if (leadingDigit == 2 || leadingDigit == 3) //for twenty and thirty
                {
                    prefixValue = 4;
                }
                else if (leadingDigit == 4 || leadingDigit == 5) //for forty and fifty
                {
                    prefixValue = 3;
                }
                else if (leadingDigit == 8) //for eighty
                {
                    prefixValue = 4;
                }
                else
                {
                    prefixValue = Stringify(leadingDigit);
                }
                return prefixValue + 2 + Stringify(num - (leadingDigit * 10));
            }

            switch (num)
            {
                case 1:
                case 2:
                case 6:
                case 10:
                    return 3;
                case 4:
                case 5:
                case 9:
                    return 4;
                case 3:
                case 7:
                case 8:
                    return 5;
                case 11:
                case 12:
                case 20:
                    return 6;
                case 13:
                case 14:
                case 18:
                case 19:
                    return 8;
                case 15:
                case 16:
                    return 7;
                case 17:
                    return 9;
            }

            return 0;
        }

        public static int GetLeadingDigit(int num)
        {
            while (num >= 10)
            {
                num /= 10;
            }

            return num;
        }
    }
}
