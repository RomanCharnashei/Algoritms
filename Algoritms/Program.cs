using Algoritms.Search;
using Algoritms.Sort;

namespace Algoritms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IAlgo algo = new BubbleSort();
            algo.DoIt();
        }
    }
}