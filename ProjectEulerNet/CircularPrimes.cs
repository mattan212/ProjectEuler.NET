using System;
using System.Collections.Generic;
using System.Text;
using ProjectEulerNet.Helpers;

namespace ProjectEulerNet
{
    public class CircularPrimes
    {
        public static int Solve(int upperboundLimit)
        {
            var options = new List<int>();
            
            for (var i = 2; i < upperboundLimit; i++)
            {
                if (PrimeNumbers.IsCircularPrime(i))
                {
                    options.Add(i);
                }
            }

            return options.Count;
        }
    }
}
