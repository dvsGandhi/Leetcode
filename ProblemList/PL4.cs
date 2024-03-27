using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ProblemList
{
    internal class PL4
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Hello");
            int[] num1 = { 1, 2 };
            int[] num2 = { 3, 4 };
        }
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double sum = 0;
            int[] sortedArray = SortedArray(nums1, nums2);
            double num = sortedArray.Length / 2;
            if (sortedArray.Length % 2 == 1)
            {
                int i = Convert.ToInt32(Math.Floor(num));
                Console.WriteLine(sortedArray[i]);
                return Convert.ToDouble(sortedArray[i]);
            }
            else
            {
                sum += sortedArray[Convert.ToInt32(num)];
                sum += sortedArray[Convert.ToInt32(num - 1)];

                return sum / 2;
            }
        }

        private bool BiggerArray(int[] l1, int[] l2)
        {
            if (l1.Length > l2.Length)
                return true;
            else
                return false;
        }

        private int[] SortedArray(int[] l1, int[] l2)
        {
            int[] newArray = new int[l1.Length + l2.Length];
            int i = l1.Length == 0 ? -1 : 0;
            int j = l2.Length == 0 ? -1 : 0;

            for (int k = 0; k < newArray.Length; k++)
            {
                if (i != -1)
                {
                    newArray[k] = l1[i];
                    i++;
                    if (i == l1.Length)
                        i = -1;
                }
                else if (j != -1)
                {
                    newArray[k] = l2[j];
                    j++;
                    if (j == l2.Length)
                        j = -1;
                }
            }
            Array.Sort( newArray );
            return newArray;
        }
        public void AssendingSorting(ref int[] arr)//selection
        {
            int len = arr.Length;
            for (int i = 0; i < len - 1; i++)
            {
                int minNum = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[j] < arr[minNum])
                    {
                        minNum = j;
                    }
                }
                int temp = arr[minNum];
                arr[minNum] = arr[i];
                arr[i] = temp;
            }
        }
    }
}
