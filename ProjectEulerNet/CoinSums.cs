using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEulerNet
{
    public class CoinSums
    {
        private static Dictionary<double, long> _cache;
        public static long Solve(double targetAmount)
        {
            int target = (int) (targetAmount * 100);

            long count = 0;
            for (var c2P = 0; c2P <= target / 200; c2P++)
            {
                double current0 = c2P * 200;
                for (double c1P = 0; c1P <= target / 100; c1P++)
                {
                    double current1 = current0 + c1P * 100;
                    if (current1 > target) break;
                    for (var c50p = 0; c50p <= target / 50; c50p++)
                    {
                        double current2 = current1 + c50p * 50;
                        if (current2 > target) break;
                        for (var c20p = 0; c20p <= target / 20; c20p++)
                        {
                            double current3 = current2 + c20p * 20;
                            if (current3 > target) break;
                            for (var c10p = 0; c10p <= target / 10; c10p++)
                            {
                                double current4 = current3 + c10p * 10;
                                if (current4 > target) break;
                                for (var c5p = 0; c5p <= target / 5; c5p++)
                                {
                                    double current5 = current4 + c5p * 5;
                                    if (current5 > target) break;
                                    for (var c2p = 0; c2p <= target / 2; c2p++)
                                    {
                                        double current6 = current5 + c2p * 2;
                                        if (current6 <= target)
                                        {
                                            count++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return count;
        }
    }
}
