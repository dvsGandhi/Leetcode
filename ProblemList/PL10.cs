using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Leetcode.ProblemList
{
    internal class PL10
    {
        public bool IsMatch(string s, string p)
        {
            //'.' Matches any single character.​​​​
            //'*' Matches zero or more of the preceding element.
            char[] pattern = p.ToCharArray();
            char toMatch = '0';
            foreach (char c in pattern)
            {
                if (Char.IsLetter(c))
                {
                    toMatch = c;
                }
            }
            if (p.Contains('*'))
            {
                return true;
            }
            else if (p.Contains('.'))
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == toMatch)
                        return true;
                    else
                        return false;
                }
            }
            else { return false; }
            return false;
        }
    }
}
