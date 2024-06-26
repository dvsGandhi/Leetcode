﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ProblemList
{
    internal class Add_2_num
    {
        ListNode head;
        public Add_2_num()
        {
            head = null;
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int sum = 0;
            int carry = 0;
            ListNode l3 = head;

            while (l1 != null || l2 != null)
            {
                if (l1 != null)
                {
                    sum += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    sum += l2.val;
                    l2 = l2.next;
                }
                sum += carry;
                ListNode temp = new ListNode(sum % 10);
                if(l3 == null)
                    head = temp;
                else
                    l3.next = temp;
                l3 = temp;
                carry = sum / 10;
                sum = 0;
            }

            if(carry == 1)
            {
                ListNode temp = new ListNode(carry);
                l3.next = temp;
                l3 = temp;
            }

            //for (int i = 0; i <= listCount - 1 || sum != 0; i++)
            //{
            //    ListNode newNode = new ListNode();
            //    if (i < listCount)
            //    {
            //        if (l1items.Count >= l2items.Count)
            //            if ((i + 1) <= l2items.Count)
            //                sum += (l1items[i] + l2items[i]);
            //            else
            //                sum += l1items[i];
            //        else
            //        {
            //            if ((i + 1) <= l1items.Count)
            //                sum += (l1items[i] + l2items[i]);
            //            else
            //                sum += l2items[i];
            //        }
            //    }

            //    if (sum.ToString().Count() > 1)
            //    {
            //        newNode.val = Convert.ToInt32(sum.ToString().Substring(sum.ToString().Count() - 1));
            //        sum = Convert.ToInt32(sum.ToString().Substring(0, sum.ToString().Count() - 1));
            //    }
            //    else
            //    {
            //        newNode.val = sum;
            //        sum = 0;
            //    }

            //    if (head == null)
            //    {
            //        head = newNode;
            //    }
            //    else
            //    {
            //        l3 = head;
            //        while (l3.next != null)
            //        {
            //            l3 = l3.next;
            //        }
            //        l3.next = newNode;
            //    }
            //}
            PrintList();
            Console.ReadLine();
            return head;
        }
        private List<int> GetListItem(ListNode l)
        {
            List<int> items = new List<int>();

            while (l != null)
            {
                items.Add(l.val);
                l = l.next;
            };
            return items;
        }

        private int ListCount(List<int> l1, List<int> l2)
        {
            if (l1.Count > l2.Count)
                return l1.Count;
            else
                return l2.Count;
        }

        private void PrintList()
        {
            ListNode temp = new ListNode();
            temp = this.head;
            if (temp != null)
            {
                while (temp != null)
                {
                    Console.Write(temp.val + " ");
                    temp = temp.next;
                }
                Console.WriteLine();
            }
            else
                Console.WriteLine("The list is empty");



        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
