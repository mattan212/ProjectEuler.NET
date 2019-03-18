using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEulerNet.Helpers;

namespace ProjectEulerNet
{
    public class PrimePermutations
    {
        public static string Solve(int index)
        {
            var primes = PrimeNumbers.GetAllPrimes().Where(x => x > 1000 && x < 10000).ToList();

            var primeStrings = primes.Select(x => x.ToString()).ToList();

            var options = new List<List<int>>();

            var considered = new HashSet<int>();

            foreach (var p in primes)
            {
                if (considered.Contains(p))
                {
                    continue;
                }
                
                var perms = GetPermutations(p, primeStrings);

                perms.ForEach(x => considered.Add(x));

                for (var a = 0; a < perms.Count; a++)
                {
                    for (var b = a + 1; b < perms.Count; b++)
                    {
                        for (var c = b + 1; c < perms.Count; c++)
                        {
                            if (perms[c] - perms[b] == perms[b] - perms[a])
                            {
                                options.Add(new List<int> {perms[a], perms[b], perms[c]});
                                a = perms.Count;
                                b = perms.Count;
                                c = perms.Count;
                            }
                        }
                    }
                }
            }

            var res = options[index].Aggregate("", (c, n) => c + n.ToString());
            
            return res;
        }

        private static List<int> GetPermutations(int prime, List<string> primes)
        {
            var asStr = prime.ToString();

            var dict = new Dictionary<char, int>();
            foreach (var c in asStr)
            {
                if (!dict.ContainsKey(c))
                {
                    dict.Add(c, 0);
                }

                dict[c]++;
            }

            var res = new List<int>();
            foreach (var p in primes)
            {
                var isPerm = true;
                foreach (var entry in dict)
                {
                    if (p.Count(x => x == entry.Key) != entry.Value)
                    {
                        isPerm = false;
                        break;
                    }
                }

                if (isPerm)
                {
                    res.Add(int.Parse(p));
                }
            }

            return res.OrderBy(x => x).ToList();
        }
    }
}
