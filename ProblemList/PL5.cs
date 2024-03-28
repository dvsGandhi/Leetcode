using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ProblemList
{
    internal class PL5
    {
        public string LongestPalindrome(string s)
        {
            string str = "";
            int left = 0;
            for (int right = s.Length - 1; right >= 0; right--)
            {
                if (s[right] == s[left])
                {
                    str += s[right];
                }
                left++;
            }
            return str;
        }
    }
}
