using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ProblemList
{
    internal class PL1
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] output = new int[2];
            for (var i = 0; i < nums.Length; i++)
            {
                for (var j = 1; j < nums.Length; j++)
                {
                    if (((nums[i]) + (nums[j])) == target)
                    {
                        output[0] = i;
                        output[1] = j;
                        Console.Write("[" + output[0] + "," + output[1] + "]");
                        return output;
                    }
                }
            }
            return output;
        }
    }
}
