using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerNet
{
    public class LatticePaths
    {
        public static long Solve(int n)
        {
            n++;
            var grid = new long[n, n];

            grid[0, 0] = 1;
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n; j++)
                {
                    if (grid[i, j] != 0)
                    {
                        continue;
                    }

                    grid[i, j] = (j > 0 ? grid[i, j - 1] : 0) +(i > 0 ? grid[i - 1, j] : 0);
                }
            }

            return grid[n - 1, n - 1];
        }
    }
}
