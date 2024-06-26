﻿using System;
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
            #region PL1
            //PL1 sa = new PL1();
            //sa.TwoSum(new[] { 0, 4, 3, 0 },0);
            //Console.ReadKey();
            #endregion

            #region PL2
            //Add_2_num addnum = new Add_2_num();
            //ListNode l13 = new ListNode(9, null);
            //ListNode l12 = new ListNode(4, l13);
            //ListNode l11 = new ListNode(2, l12);

            //ListNode l24 = new ListNode(9, null);
            //ListNode l23 = new ListNode(4, l24);
            //ListNode l22 = new ListNode(6, l23);
            //ListNode l21 = new ListNode(5, l22);

            //addnum.AddTwoNumbers(l11, l21);
            #endregion

            #region PL4
            //PL4 pL4 = new PL4();
            //int[] num1 = { };
            //int[] num2 = { 4 };
            //Console.WriteLine(pL4.FindMedianSortedArrays(num1, num2));
            #endregion

            #region PL5
            //PL5 pl5 = new PL5();
            //Console.WriteLine(pl5.LongestPalindrome("babad"));
            #endregion

            #region PL7
            //PL7 pL7 = new PL7();
            //Console.WriteLine(pL7.Reverse(1534236469));
            #endregion

            #region PL8
            //PL8 pL8 = new PL8();
            //Console.Write(pL8.MyAtoi("   -321 random string"));
            #endregion

            #region PL10
            //PL10 pL10 = new PL10();
            //Console.WriteLine(pL10.IsMatch("aa", "a*"));
            #endregion

            #region PL13
            PL13 pL13 = new PL13();
            Console.Write(pL13.RomanToInt("MCMXCIV"));
            #endregion

            Console.ReadLine();
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
