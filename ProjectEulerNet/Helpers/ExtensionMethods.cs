using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerNet.Helpers
{
    public static class ExtensionMethods
    {
        public static string Add(this string a, string b, int truncate = -1)
        {
            string sum = "";

            bool hasCarry = false;

            if (b.Length > a.Length)
            {
                var temp = a;
                a = b;
                b = temp;
            }

            int current;
            for (var i = 0; i < a.Length; i++)
            {
                if (truncate != -1 && i > truncate)
                {
                    break;
                }

                if (b.Length - i - 1 >= 0)
                {
                    current = (a[a.Length - 1 - i] - '0') + (b[b.Length - 1 - i] - '0') + (hasCarry ? 1 : 0);

                    if (current >= 10)
                    {
                        hasCarry = true;
                        sum = (current % 10) + sum;
                    }
                    else
                    {
                        hasCarry = false;
                        sum = current + sum;
                    }
                }
                else
                {
                    current = (a[a.Length - 1 - i] - '0') + (hasCarry ? 1 : 0);

                    if (current >= 10)
                    {
                        hasCarry = true;
                        sum = (current % 10) + sum;
                    }
                    else
                    {
                        hasCarry = false;
                        sum = current + sum;
                    }
                }
            }

            if (hasCarry)
            {
                sum = '1' + sum;
            }

            return sum;
        }

        public static string Multiply(this string a, int n, int truncate = -1)
        {
            if (n == 0)
            {
                return "0";
            }

            var total = a;

            for (var i = 0; i < n - 1; i++)
            {
                total = total.Add(a, truncate);
            }

            return total;
        }

        public static string Pow(this string a, int n)
        {
            if (n == 0)
            {
                return "1";
            }

            var factor = int.Parse(a);
            for (var i = 1; i < n; i++)
            {
                a = a.Multiply(factor);
            }

            return a;
        }

        public static int AggregateDigits(this string a)
        {
            var res = 0;

            foreach (var c in a)
            {
                res += c - '0';
            }

            return res;
        }

        public static bool IsPalindrome(this string str)
        {
            var start = 0;
            var end = str.Length - 1;

            while (start < end)
            {
                if (str[start++] != str[end--])
                {
                    return false;
                }
            }

            return true;
        }

        public static string DivideByOne(this int divisor, int accuracy)
        {
            var res = "0.";

            var carry = 1;

            while (carry != 0 && accuracy-- >= 0)
            {
                var temp = carry * 10;
                res += temp / divisor;
                carry = temp % divisor;
            }

            return res.TrimEnd('0');
        }

        public static IEnumerable<int> Digits(this int num)
        {
            var res = new List<int>();
            while (num > 0)
            {
                res.Add(num % 10);
                num /= 10;
            }

            res.Reverse();

            return res;
        }
    }
}
