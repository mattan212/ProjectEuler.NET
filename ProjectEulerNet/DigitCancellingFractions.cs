using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerNet
{
    public class DigitCancellingFractions
    {
        public static double Solve(int digitCount)
        {
            var options = new List<Tuple<int, int>>();
            for (var denominator = 10; denominator < Math.Pow(10, digitCount); denominator++)
            {
                for (var numerator = 10; numerator < denominator; numerator++)
                {
                    if (IsTrivial(numerator, denominator))
                    {
                        continue;
                    }

                    if (IsCurious(numerator, denominator))
                    {
                        options.Add(new Tuple<int, int>(numerator, denominator));
                    }
                }
            }

            var a = 1;
            var b = 1;
            foreach (var option in options)
            {
                a *= option.Item1;
                b *= option.Item2;
            }

            for (var i = 2; i < b / 2 + 1; i++)
            {
                if (a % i == 0 && b % i == 0)
                {
                    a /= i;
                    b /= i;
                    i--;
                }
            }

            return b;
        }

        private static bool IsTrivial(int numerator, int denominator)
        {
            return (numerator % 10 == 0 && denominator % 10 == 0);
        }

        private static bool IsCurious(int numerator, int denominator)
        {
            var numeratorStr = numerator.ToString();
            var denominatorStr = denominator.ToString();

            decimal target = (decimal)numerator / (decimal)denominator;
            for (var i = 0; i < numeratorStr.Length; i++)
            {
                for (var j = 0; j < denominatorStr.Length; j++)
                {
                    if (denominatorStr[j] == numeratorStr[i])
                    {
                        var newNum = decimal.Parse(numeratorStr.Remove(i, 1));
                        var newDenom = decimal.Parse(denominatorStr.Remove(j, 1));
                        if (newDenom == 0)
                        {
                            continue;
                        }

                        decimal result = newNum / newDenom;
                        if (result == target)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }
    }
}
