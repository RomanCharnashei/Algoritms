using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Algoritms.Search
{
    public class BinarySearch : IAlgo
    {
        //public static void DoIt()
        //{
        //    int[] data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
        //    int subject = 19;

        //    int length = data.Length;
        //    int leftStart = 0;
        //    int rightEnd = length - 1;
        //    int middle;

        //    if (length == 0 || data[0] > subject || data[length - 1] < subject)
        //    {
        //        Console.WriteLine("Result: Not Found");
        //    }

        //    do
        //    {
        //        middle = (leftStart + rightEnd) / 2; // индекс середины т.е. половина длинны начиная от левого индекса

        //        if (data[middle] > subject)
        //        {
        //            // left
        //            rightEnd = middle - 1;

        //        }
        //        else
        //        {
        //            // right
        //            leftStart = middle + 1;
        //        }

        //    } while (data[middle] != subject);


        //    Console.WriteLine($"Result: {data[middle]}");
        //}

        public void DoIt()
        {
            int[] data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            int subject = 19;

            int middle, left = 0, right = data.Length - 1;

            do
            {
                middle = (left + right) / 2;
                if (subject > data[middle])
                    left = middle + 1;
                else
                    right = middle - 1;
            }
            while ((data[middle] != subject) && (left <= right));

            if (data[middle] == subject)
                Console.WriteLine($"Result: {data[middle]}");
            else
                Console.WriteLine("Result: Not Found");
        }
    }
}
