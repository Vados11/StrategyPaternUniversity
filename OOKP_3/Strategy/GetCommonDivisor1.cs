using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOKP_3.Strategy
{
    public class GetCommonDivisor1 : IStrategy
    {
        public long Algorithm(long a, long b)
        {
            if (a == b)
            {
                return a;
            }
            if (a > b)
            {
                long tmp = a;
                a = b;
                b = tmp;
            }
            return Algorithm(a, b - a);
        }
    }
}
