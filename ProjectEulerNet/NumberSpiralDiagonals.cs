using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerNet
{
    public enum EDirection { North, South, East, West }

    public class NumberSpiralDiagonals
    {
        public static int Solve(int n)
        {
            var matrix = new int[n, n];

            var current = n * n;
            var direction = EDirection.East;
            var i = 0;
            var j = 0;
            while (current > 0)
            {
                matrix[i, j] = current--;

                switch (direction)
                {
                    case EDirection.East:
                        if (j >= n - 1|| matrix[i, j + 1] != 0)
                        {
                            direction = EDirection.South;
                            i++;
                        }
                        else
                        {
                            j++;
                        }
                        break;
                    case EDirection.South:
                        if (i >= n - 1 || matrix[i + 1, j] != 0)
                        {
                            direction = EDirection.West;
                            j--;
                        }
                        else
                        {
                            i++;
                        }
                        break;
                    case EDirection.West:
                        if (j - 1 < 0 || matrix[i, j - 1] != 0)
                        {
                            direction = EDirection.North;
                            i--;
                        }
                        else
                        {
                            j--;
                        }
                        break;
                    case EDirection.North:
                        if (i < 1 || matrix[i - 1, j] != 0)
                        {
                            direction = EDirection.East;
                            j++;
                        }
                        else
                        {
                            i--;
                        }
                        break;
                    default:
                        break;
                }
            }

            var res = 0;
            for (var a = 0; a < n; a++)
            {
                res += matrix[a, a];
            }

            for (var a = 0; a < n; a++)
            {
                res += matrix[a, n - 1 - a];
            }

            return res - 1;
        }
    }
}
