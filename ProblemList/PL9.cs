using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ProblemList
{
    internal class PL9
    {
        public bool IsPalindrome(int x)
        {
            int r, sum = 0;
            int temp =  x;
            while (x > 0)
            {
                r = x % 10;
                sum = (sum * 10) + r;
                x=x/10;
            }
            if(temp == sum)
                return true;
            else
                return false;
        }
    }
}
