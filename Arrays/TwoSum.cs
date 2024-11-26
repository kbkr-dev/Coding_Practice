using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Practice.Arrays
{
    public class TwoSum
    {
        public int[] TwoSumCal(int[] nums, int target)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] + nums[i + 1] == target)
                {
                    result.Add(i);
                    result.Add(i + 1);
                    break;
                }
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result.Add(i);
                        result.Add(j);
                        break;
                    }
                }
            }
            return result.ToArray();
        }
    }
}
