using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Practice.Practice
{
    public class MinCoins
    {
        public int MinCoinsBruteForce(int[] arr, int amt)
        {
            if (amt < 0) return int.MaxValue;

            if (amt == 0) return 0;

            int mincoins = int.MaxValue;

            foreach (int i in arr)
            {
                var res = MinCoinsBruteForce(arr, amt - i);

                if(res != int.MaxValue)
                {
                    mincoins = Math.Min(mincoins, res + 1);
                }
            }

            return mincoins;
        }


        public (int, List<int>) MinCoinsDP(int[] coins, int amt)
        {
            int[] dp = new int[amt+1];
            int[] track = new int[amt+1];
            Array.Fill(dp, int.MaxValue);
            dp[0] = 0;


            foreach(int coin in coins)
            {
                for(int curr = coin; curr <= amt; curr++)
                {
                    if (dp[curr - coin] != int.MaxValue)
                    {
                        if (dp[curr] >  dp[curr - coin] + 1)
                        {
                            dp[curr] = dp[curr - coin] + 1;
                            track[curr] = coin;
                        }
                    }
                }
            }

            List<int> coinCombination = new List<int>();
            int remainingAmt = amt;

            while (remainingAmt > 0)
            {
                if (dp[remainingAmt] == int.MaxValue)
                {
                    return (-1, new List<int>());
                }

                int usedCoin = track[remainingAmt];
                coinCombination.Add(usedCoin);
                remainingAmt -= usedCoin;
            }

            return (dp[amt],  coinCombination);
        }
    }
}
