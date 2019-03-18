using System;
using System.Collections.Generic;
using System.Text;
using ProjectEulerNet.Helpers;

namespace ProjectEulerNet
{
    public class SmallestMultiple
    {
        public static int Solve(int cutoff)
        {
            if (cutoff % 2 != 0)
            {
                cutoff--;
            }
                        
            for (var i = cutoff; i < int.MaxValue; i+=cutoff)
            {
                var res = true;
                for (var j = cutoff - 1; j > 2; j--)
                {
                    var divisible = i % j == 0;
                    res = res && divisible;
                    if (!divisible)
                    {
                        break;
                    }
                }
                
                if (res)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
