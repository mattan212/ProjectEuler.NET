using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerNet
{
    public class ChampernownesConstant
    {
        public static int Solve(List<int> indices)
        {
            var index = 0;
            var res = 1;
            var currentIndex = 0;
            indices.Remove(1);
            for (var i = 1; i < indices.Max() + 1; i++)
            {
                index += i.ToString().Length;
                if (index > indices[currentIndex])
                {
                    var offset = index - indices[currentIndex];
                    var current = i.ToString().ElementAt(i.ToString().Length - offset - 1) - '0';
                    res *= current;
                    currentIndex++;
                    if (currentIndex >= indices.Count)
                    {
                        break;
                    }
                }
            }
            
            return res;
        }
    }
}
