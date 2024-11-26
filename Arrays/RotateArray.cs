using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Practice.Arrays
{
    public class RotateArray
    {
        public void Rotate(int[] nums, int k)
        {
            k = k % nums.Length;
            if (nums.Length > 1)
            {
                Reverse(nums, 0, nums.Length - 1);
                Reverse(nums, 0, k - 1);
                Reverse(nums, k, nums.Length - 1);
            }
        }

        public void Rotate1(int[] nums, int k)
        {
            k = k % nums.Length;
            if (k == 0)
                return;

            Array.Reverse(nums, 0, nums.Length);

            Array.Reverse(nums, 0, k);

            Array.Reverse(nums, k, nums.Length - k);
        }

        private int[] Reverse(int[] arr, int start, int end)
        {
            while (start < end)
            {
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }

            return arr;
        }
    }
}
