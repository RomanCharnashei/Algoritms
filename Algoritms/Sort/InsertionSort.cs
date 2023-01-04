using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Sort
{
    public class InsertionSort : IAlgo
    {
        public void DoIt()
        {
            int[] data = new int[] { 9, 2, 8, 5, 1, 3, 7, 4, 6 };
            int length = data.Length;

            for (int sortedIndex = 0; sortedIndex < length; sortedIndex++)
            {
                int loopBackIndex = sortedIndex;

                while (loopBackIndex > 0)
                {
                    if (data[loopBackIndex] < data[loopBackIndex - 1])
                    {
                        int swap = data[loopBackIndex];
                        data[loopBackIndex] = data[loopBackIndex - 1];
                        data[loopBackIndex - 1] = swap;
                    }
                    --loopBackIndex;
                }
            }

            Console.WriteLine(string.Join(", ", data));
            Console.ReadLine();
        }
    }
}
