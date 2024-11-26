using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Practice.Arrays
{
    public class ContainsDuplicate
    {
        public bool ContainsDuplicateCal(int[] nums)
        {
            HashSet<int> hash = new HashSet<int>();
            if (nums.Length > 0)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (hash.Contains(nums[i]))
                    {
                        return true;
                    }
                    else
                    {
                        hash.Add(nums[i]);
                    }
                }
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
                    if (nums[j] == temp)
                    {
                        return true;
                    }

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
