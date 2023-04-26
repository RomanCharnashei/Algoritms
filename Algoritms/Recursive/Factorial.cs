using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Recursive
{
    public class Factorial : IAlgo
    {
        public void DoIt()
        {
            Console.WriteLine(CalcI(5));
        }

        public int Calc(int value)
        {
            int result;
            if (value == 1)
                result = 1;
            else
                result = value * Calc(value - 1);
            return result;
        }
        static int CalcI(int k)
        {
            int result = 1;
            for (int i = 1; i <= k; i++)
                result *= i;
            return result;
        }
    }
}
