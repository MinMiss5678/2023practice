using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023practice
{
    internal class TwoSum
    {
        public static int[] TwoSum1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return Array.Empty<int>();
        }

        public static int[] TwoSum2(int[] nums, int target)
        {
            var pairs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (pairs.TryGetValue(target - nums[i], out int value))
                {
                    return new int[] { value, i };
                }

                else
                {
                    pairs.TryAdd(nums[i], i);
                }
            }

            return Array.Empty<int>();
        }
    }
}
