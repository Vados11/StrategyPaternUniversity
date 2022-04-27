using OOKP_3.Strategy;
using System;

namespace OOKP_3
{
    class Program
    {
        public static void StrategyMethod()
        {
            IStrategy calculateMethod1 = new GetCommonDivisor1();
            IStrategy calculateMethod2 = new GetCommonDivisor2();

            Context commonDivisor = new Context(20, 4, calculateMethod1);

            commonDivisor.Print();
            commonDivisor.ExecuteAlgorithm(calculateMethod2);
            commonDivisor.Print();
        }

        static void Main(string[] args)
        {
            StrategyMethod();
        }
    }
}
