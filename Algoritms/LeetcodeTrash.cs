using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    public class LeetcodeTrash : IAlgo
    {
        public void DoIt()
        {
            int[] costs = { 1, 6, 3, 1, 2, 5 };
            int coins = 20;



            Console.WriteLine(Maximum_Ice_Cream_Bars_1833(costs, coins));
        }

        public int Maximum_Ice_Cream_Bars_1833(int[] costs, int coins)
        {
            int purchaseCoins = 0;
            int purchaseCount = 0;
            int length = costs.Length;

            //for (int countdown = length - 1; countdown >= 0; countdown--)
            //{
            //    for (int index = 0; index < countdown; index++)
            //    {
            //        if (costs[index + 1] < costs[index])
            //        {
            //            int swap = costs[index];
            //            costs[index] = costs[index + 1];
            //            costs[index + 1] = swap;
            //        }
            //    }
            //}

            Array.Sort(costs);

            while (purchaseCount < length)
            {
                purchaseCoins = purchaseCoins + costs[purchaseCount];

                if (purchaseCoins > coins)
                {
                    break;
                }

                purchaseCount = purchaseCount + 1;
            }

            return purchaseCount;
        }
    }
}
