using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Recursive
{
    public class Fibonacci : IAlgo
    {
        public void DoIt()
        {
            Console.WriteLine(Fib(2));
        }

        public int Fib(int n)
        {
            if (n <= 1)
            {
                return n;
            }

            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
