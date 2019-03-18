using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerNet
{
    /// <summary>
    /// https://projecteuler.net/problem=4
    /// </summary>
    public class LargestPalindromeProduct
    {
        public static int Solve(int digitCount)
        {
            var lowerBoundary = Math.Pow(10, digitCount - 1);

            var upperBoundary = Math.Pow(10, digitCount);

            var options = new List<int>();

            for (var i = upperBoundary - 1; i >= lowerBoundary; i--)
            {
                for (var j = upperBoundary - 1; j >= lowerBoundary; j--)
                {
                    var product = (int)(i * j);

                    if (IsPalindrome(product))
                    {
                        options.Add(product);
                    }
                }
            }

            return options.Max();
        }

        private static bool IsPalindrome(int number)
        {
            var asStr = number.ToString();

            var i = 0;
            var j = asStr.Length - 1;

            while (i < j)
            {
                if (asStr[i] != asStr[j])
                {
                    return false;
                }

                i++;
                j--;
            }

            return true;
        }
    }
}
