using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Search
{
    public class SimpleSearch : IAlgo
    {
        public void DoIt()
        {
            var intitData = new int[] { 1, 3, 4, 5, 3, 5, 78, 98, 45, 3, 3, 6, 8 };
            var length = intitData.Length;
            var index = 0;
            var subject = 45;

            while (index != length && intitData[index] != subject)
            {
                index++;
            }

            Console.WriteLine($"Result: {intitData[index]}");

            Console.WriteLine("Finish");
            Console.ReadLine();
        }
    }
}
