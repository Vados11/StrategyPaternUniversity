using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOKP_3.Strategy
{
    public class Context
    {
        protected long a { get; set; }
        protected long b { get; set; }
        public IStrategy ContextStrategy;

        public Context(long a, long b, IStrategy _strategy)
        {
            this.a = a;
            this.b = b;
            ContextStrategy = _strategy;
        }

        
        public void ExecuteAlgorithm(IStrategy ChangeAlgorithm )
        {
            if (ChangeAlgorithm == null)
            {
                Console.WriteLine(ChangeAlgorithm);
            }

            ContextStrategy = ChangeAlgorithm;
        }

        public void Print()
        {
            Console.WriteLine($"The largest common divisor: {ContextStrategy.Algorithm(this.a, this.b)}\n");
        }
    }
}
