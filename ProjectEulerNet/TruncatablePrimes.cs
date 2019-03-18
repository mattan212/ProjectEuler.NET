using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEulerNet.Helpers;

namespace ProjectEulerNet
{
    public class TruncatablePrimes
    {
        public static int Solve(int upperboundLimit)
        {
            var options = new List<int>();

            for (var i = 10; i < upperboundLimit; i++)
            {
                if (PrimeNumbers.IsTruncatable(i))
                {
                    options.Add(i);
                }
            }

            return options.Sum();
        }
    }
}
