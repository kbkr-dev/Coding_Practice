using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Coding_Practice
{

    public class BenchmarkTest
    {
        private int[] smallArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 1 };
        private int[] largeArray = new int[10000];

        public BenchmarkTest()
        {
            var rand = new Random();
            for (int i = 0; i < largeArray.Length; i++)
                largeArray[i] = rand.Next(0, 10000);
        }

        [Benchmark]
        public bool HashSetApproach() => ContainsDuplicateCal(smallArray);

        [Benchmark]
        public bool InsertionSortApproach() => ContainsDuplicateCal1(smallArray);

        [Benchmark]
        public bool SortApproach() => ContainsDuplicateCal2(smallArray);

        public bool ContainsDuplicateCal(int[] nums)
        {
            HashSet<int> hash = new HashSet<int>();
            foreach (var num in nums)
            {
                if (hash.Contains(num)) return true;
                hash.Add(num);
            }
            return false;
        }

        public bool ContainsDuplicateCal1(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                int temp = nums[i];
                int j = i - 1;
                while (j >= 0 && nums[j] >= temp)
                {
                    if (nums[j] == temp) return true;
                    nums[j + 1] = nums[j];
                    j--;
                }
                nums[j + 1] = temp;
            }
            return false;
        }

        public bool ContainsDuplicateCal2(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == nums[i - 1])
                    return true;
            }
            return false;
        }
    }
}
