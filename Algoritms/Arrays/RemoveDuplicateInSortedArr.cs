using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Arrays
{
    public class RemoveDuplicateInSortedArr : IAlgo
    {
        public void DoIt()
        {
            int[] data = {1, 2, 3, 3, 4, 4, 5, 5 };

            //Console.WriteLine(string.Join(", ", RemoveDuplicate(data)));
            Console.WriteLine(RemoveDuplicate2(data));
            Console.ReadLine();
        }

        public int[] RemoveDuplicate(int[] data)
        {
            bool makeOffset = false;
            int offsetCounter = 0;

            for (int i = 0; i < data.Length - offsetCounter - 1; i++)
            {
                if (makeOffset)
                {
                    for (int j = i; j < data.Length; j++)
                    {
                        data[j - 1] = data[j];
                    }
                    makeOffset = false;
                }

                if (data[i] == data[i + 1])
                {
                    makeOffset = true;
                    ++offsetCounter;
                }
            }

            int[] result = new int[data.Length - offsetCounter];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = data[i];
            }

            return result;
        }

        public int RemoveDuplicate2(int[] data)
        {
            int length = data.Length;

            if (length == 0)
            {
                return 0;
            }

            int compresedEdge = 0;
            int index = 1;

            while (index < length)
            {
                if (data[index] != data[compresedEdge])
                {
                    compresedEdge = compresedEdge + 1;
                    data[compresedEdge] = data[index];
                }
                index = index + 1;
            }

            return compresedEdge + 1;
        }
    }
}
