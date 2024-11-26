using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Practice.Arrays
{
    public class MoveZeroes
    {
        public void MoveZeroesCal(int[] nums)
        {
            int n = nums.Length;
            int c = 0;
            for (int i = 0; i < n; i++)
            {
                if (nums[i] != 0)
                {
                    nums[c++] = nums[i];
                }
            }
            while (c < n)
            {
                nums[c++] = 0;
            }
        }
        public void MoveZeroesCal1(int[] nums)
        {
            var p = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    var a = nums[i];
                    var b = nums[p];
                    nums[i] = b;
                    nums[p] = a;
                    p++;

                }
            }
        }
    }
}
