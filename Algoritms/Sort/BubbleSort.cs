using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Sort
{
    public class BubbleSort : IAlgo
    {
        public void DoIt()
        {
            int[] data = new int[] { 9, 2, 8, 5, 1, 3, 7, 4, 6 };
            int length = data.Length;

            for (int countdown = length - 1; countdown >= 0; countdown--)
            {
                for (int index = 0; index < countdown; index++)
                {
                    if (data[index + 1] < data[index])
                    {
                        int swap = data[index];
                        data[index] = data[index + 1];
                        data[index + 1] = swap;
                    }
                }
            }

            Console.WriteLine(string.Join(", ", data));
            Console.ReadLine();
        }
    }
}
