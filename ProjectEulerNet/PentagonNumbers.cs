using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerNet
{
    public class PentagonNumbers
    {
        public static int Solve(int upperboundLimit)
        {
            var pentagonNumbers = new List<int>();
            var pentagonNumbersSet = new HashSet<int>();

            for (var i = 1; i < upperboundLimit; i++)
            {
                var asPentagon = (int)(i * (3 * i - 1) / 2);

                pentagonNumbers.Add(asPentagon);
                pentagonNumbersSet.Add(asPentagon);
            }

            var min = int.MaxValue;
            for (var i = 0; i < pentagonNumbers.Count; i++)
            {
                for (var j = i + 1; j < pentagonNumbers.Count; j++)
                {
                    var a = pentagonNumbers[i];
                    var b = pentagonNumbers[j];
                    if (pentagonNumbersSet.Contains(a + b) && pentagonNumbersSet.Contains(Math.Abs(a - b)))
                    {
                        min = Math.Min(Math.Abs(a - b), min);
                    }
                }
            }

            return min;
        }
    }
}
