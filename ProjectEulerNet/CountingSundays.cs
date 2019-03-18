using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerNet
{
    public class CountingSundays
    {
        public static int Solve(DateTime start, DateTime end)
        {
            var res = 0;

            while (start <= end)
            {
                if (start.Day == 1 && start.DayOfWeek == DayOfWeek.Sunday)
                {
                    res++;
                }

                start = start.AddDays(1);
            }

            return res;

        }
    }
}
