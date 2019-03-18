using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerNet
{
    public class TriangularPentagonalAndHexagonal
    {
        public static long Solve(int n) //n being the index of the common number. so for n==2 the result would be 40755
        {
            var triangularSet = new HashSet<long>();
            var pentagonsSet = new HashSet<long>();
            var hexagonalsSet = new HashSet<long>();

            var commons = new HashSet<long>();

            long index = 1;
            while (commons.Count < n)
            {
                var t = (long) (index * (index + 1) / 2);
                var p = (long) (index * (3 * index - 1) / 2);
                var h = (long) (index * (2 * index - 1));

                triangularSet.Add(t);
                pentagonsSet.Add(p);
                hexagonalsSet.Add(h);

                if (pentagonsSet.Contains(t) && hexagonalsSet.Contains(t))
                {
                    commons.Add(t);
                }

                if (triangularSet.Contains(p) && hexagonalsSet.Contains(p))
                {
                    commons.Add(p);
                }

                if (triangularSet.Contains(h) && pentagonsSet.Contains(h))
                {
                    commons.Add(h);
                }

                index++;
            }

            return commons.Last();
        }
    }
}
