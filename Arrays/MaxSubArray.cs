using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Practice.Arrays
{
    public class MaxSubArray
    {
        public int MaxSubArrayCal(int[] nums)
        {
            int max_so_far = nums[0];
            int sum_including_curr = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                sum_including_curr = Math.Max(nums[i], nums[i] + sum_including_curr);
                max_so_far = Math.Max(max_so_far, sum_including_curr);
            }
            return max_so_far;
        }

        public int MaxSubArrayCal1(int[] nums)
        {
            if (nums.Length == 1)
                return nums[0];
            int sum = 0, max = int.MinValue;
            foreach (int num in nums)
            {
                sum += num;
                if (sum > max)
                    max = sum;
                if (sum < 0)
                    sum = 0;
            }
            return max;
        }
    }
}
