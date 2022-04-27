using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOKP_3.Strategy
{
    class GetCommonDivisor2 : IStrategy
    {
        public long Algorithm(long a, long b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    long tmp = a;
                    a = b;
                    b = tmp;
                }
                b = b - a;
            }
            return a;
        }
    }
}
