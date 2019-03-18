using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerNet
{
    /// <summary>
    /// https://projecteuler.net/problem=9
    /// </summary>
    public class SpecialPythagoreanTriplet
    {
        public static int Solve(int n)
        {
            var sqrtN = Math.Sqrt(Math.Pow(n, 2) * 2);
            for (var a = 1; a < sqrtN; a++)
            {
                for (var b = 1; b < sqrtN; b++)
                {
                    var c = GetPythagorean(a, b);
                    if (Math.Ceiling(c) == Math.Floor(c))
                    {
                        if (a + b + (int)c == n)
                        {
                            return a * b * (int)c;
                        }
                    }
                }
            }

            return -1;
        }

        public static double GetPythagorean(int a, int b)
        {
            return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        }
    }
}
