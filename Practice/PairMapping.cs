using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Practice.Practice
{
    public static class PairMapping
    {
        public static void Pair()
        {
            int[] arr = [1, 2, 3, 4, 5];

            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0;j<arr.Length; j++)
                {
                    Console.WriteLine($"Pair - ({arr[i]}, {arr[j]})");
                }
            }
        }
    }
}
