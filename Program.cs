using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leetcode.ProblemList;

namespace Leetcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sum sa = new Sum();
            //sa.TwoSum(new[] { 2,7,11,15},9);

            Add_2_num addnum = new Add_2_num();
            ListNode l13 = new ListNode(9, null);
            ListNode l12 = new ListNode(4, l13);
            ListNode l11 = new ListNode(2, l12);

            ListNode l24 = new ListNode(9, null);
            ListNode l23 = new ListNode(4, l24);
            ListNode l22 = new ListNode(6, l23);
            ListNode l21 = new ListNode(5, l22);

            addnum.AddTwoNumbers(l11, l21);
        }
    }
    internal class Sum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] output = new int[2];
            for (int i = 1; i < nums.Length; i++)
            {
                if (((nums[i - 1]) + (nums[i])) == target)
                {
                    output[0] = i - 1;
                    output[1] = i;
                    Console.Write("[" + output[0] + "," + output[1] + "]");
                }
            }
            return output;
        }
    }

}
