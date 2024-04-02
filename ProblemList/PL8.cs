using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ProblemList
{
    internal class PL8
    {
        public int MyAtoi(string s)
        {
            try
            {
                return Convert.ToInt32(s);
            }
            catch (Exception e)
            {
                string str = "";
                bool isFirst = true;
                for (int i = 0; i < s.Length; i++)
                {
                    if ((char.IsLetter(s[i]) || s[i] == '.') && isFirst) return 0;
                    if (Char.IsDigit(s[i]))
                    {
                        str += s[i];
                        isFirst = false;
                    }
                }
                try
                {
                    return Convert.ToInt32(str);
                }
                catch (Exception ex)
                {
                    return 0;
                }
            }
        }
    }
}
