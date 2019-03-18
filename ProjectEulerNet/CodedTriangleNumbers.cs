using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectEulerNet
{
    public class CodedTriangleNumbers
    {
        public static int Solve()
        {
            var triangleNumbers = new HashSet<int>();

            for (var i = 1; i < 1000; i++)
            {
                triangleNumbers.Add((int)(0.5 * i * (i + 1)));
            }

            var words = File.ReadAllText(Path.Combine("DataFiles", "p042_words.txt")).Split(',').Select(x => x.Trim('\"'));

            return words.Count(x => triangleNumbers.Contains(x.Sum(y => y - 'A' + 1)));
        }

    }
}
