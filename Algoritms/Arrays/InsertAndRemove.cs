using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Arrays
{
    public class InsertAndRemove : IAlgo
    {
        public void DoIt()
        {
            int[] init = { 1, 2, 4, 5 };

            var insert = Insert(init, 2, 3);
            var remove = Remove(init, 2);

            Console.WriteLine(string.Join(", ", insert));
            Console.WriteLine(string.Join(", ", remove));

            Console.ReadLine();
        }

        public int[] Insert(int[] init, int position, int value)
        {
            int[] result = new int[init.Length + 1];

            for (int i = 0; i < init.Length; i++)
            {
                result[i] = init[i];
            }

            for (int i = result.Length - 1; i > position; i--)
            {
                result[i] = result[i - 1];
            }

            result[position] = value;

            return result;
        }

        public int[] Remove(int[] init, int position)
        {
            int[] result = new int[init.Length - 1];

            for (int i = position; i < init.Length - 1; i++)
            {
                init[i] = init[i + 1];
            }

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = init[i];
            }

            return result;
        }
    }
}
