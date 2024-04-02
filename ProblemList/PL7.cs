using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ProblemList
{
    internal class PL7
    {
        public int Reverse(int x)
        {
            char[] str = x.ToString().ToCharArray();
            int start = 0;
            int end = str.Length - 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != '-')
                {
                    if (end > start)
                    {
                        char temp = str[end];
                        str[end] = str[start];
                        str[start] = temp;
                        end--;
                        start++;
                    }
                }
                else
                {
                    start++;
                }
            }
            string s = new string(str);
            try
            {
                return Convert.ToInt32(new string(str));
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
