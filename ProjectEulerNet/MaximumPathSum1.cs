using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEulerNet.Models;

namespace ProjectEulerNet
{
    /// <summary>
    /// https://projecteuler.net/problem=18
    /// </summary>
    public class MaximumPathSum1
    {
        /// <summary>
        /// Pyramid is a triangle shaped, space separated in-line and new-line seperated string representation of the input.
        /// </summary>
        /// <param name="pyramid"></param>
        /// <returns></returns>
        public static long Solve(string pyramid)
        {
            var lines = pyramid.Split(Environment.NewLine);

            var rows = lines.Select(x => x.Split(' ').Select(y => int.Parse(y)).ToArray()).ToArray();

            for (var i = rows.Length - 1; i > 0; i--)
            {
                for (var j = 0; j < rows[i].Count() - 1; j++)
                {
                    rows[i - 1][j] += Math.Max(rows[i][j], rows[i][j + 1]);
                }
            }

            return rows[0][0];
        }

        private static void AggregateValues(BinaryTree<int> tree)
        {
            if (tree != null) { 
                
                AggregateValues(tree.Left);

                AggregateValues(tree.Right);

                tree.Value = tree.Value + Math.Max(tree.Left?.Value ?? 0, tree.Right?.Value ?? 0);
            }
        }
    }
}
