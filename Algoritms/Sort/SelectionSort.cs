using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Sort
{
    public class SelectionSort : IAlgo
    {
        public void DoIt()
        {
            int[] data = new int[] { 9, 2, 8, 5, 1, 3, 7, 4, 6 };
            int length = data.Length;

            for (int outerIndex = 0; outerIndex < length - 1; outerIndex++)
            {
                int minValIndex = outerIndex;
                int innerIndex = outerIndex + 1;

                while (innerIndex < length)
                {
                    if (data[innerIndex] < data[minValIndex])
                    {
                        minValIndex = innerIndex;
                    }
                    ++innerIndex;
                }

                int swap = data[outerIndex];
                data[outerIndex] = data[minValIndex];
                data[minValIndex] = swap;
            }

            Console.WriteLine(string.Join(", ", data));
            Console.ReadLine();
        }
    }
}
