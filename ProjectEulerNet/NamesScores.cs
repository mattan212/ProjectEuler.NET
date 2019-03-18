using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ProjectEulerNet.Helpers;

namespace ProjectEulerNet
{
    public class NamesScores
    {
        public static long Solve()
        {
            var names = File.ReadAllText(Path.Combine("DataFiles", "p022_names.txt")).Split(',').Select(x => x.Trim('\"')).OrderBy(x => x).ToArray();

            long res = 0;

            for (var i = 1; i <= names.Length; i++)
            {
                if (i == 938)
                {

                }
                var current = i * GetNameValue(names[i - 1]);
                res += current;
            }

            return res;
        }

        private static int GetNameValue(string name)
        {
            var res = 0;
            name = name.ToUpper();
            foreach (var c in name)
            {
                res += c - 'A' + 1;
            }
            return res;
        }

    }
}
