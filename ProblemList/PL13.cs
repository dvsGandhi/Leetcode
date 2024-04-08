using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.ProblemList
{
    internal class PL13
    {
        static private Dictionary<string, int> data = new Dictionary<string, int> { { "I", 1 }, { "V", 5 }, { "X", 10 }, { "L", 50 }, { "C", 100 }, { "D", 500 }, { "M", 1000 } };
        public int RomanToInt(string s)
        {
            int no = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i + 1 < s.Length)
                {
                    string speacialnumber = s[i].ToString() + s[i + 1].ToString();
                    if (speacialnumber == "IV")
                    {
                        no += 4;
                        i++;
                    }
                    else if (speacialnumber == "IX")
                    {
                        no += 9;
                        i++;
                    }
                    else if (speacialnumber == "XL")
                    {
                        no += 40; 
                        i++;
                    }
                    else if (speacialnumber == "XC")
                    {
                        no += 90;
                        i++;
                    }
                    else if (speacialnumber == "CD")
                    {
                        no += 400; 
                        i++;
                    }
                    else if (speacialnumber == "CM")
                    {
                        no += 900; 
                        i++;
                    }
                    else
                    {
                        no += returnRomanToInt(s[i]);
                    }
                }
                else
                {
                    no += returnRomanToInt(s[i]);
                }
            }
            return no;
        }

        private int returnRomanToInt(char s)
        {
            int n = 0;
            switch (s)
            {
                case 'I':
                    data.TryGetValue("I", out n);
                    break;
                case 'V':
                    data.TryGetValue("V", out n);
                    break;
                case 'X':
                    data.TryGetValue("X", out n);
                    break;
                case 'L':
                    data.TryGetValue("L", out n);
                    break;
                case 'C':
                    data.TryGetValue("C", out n);
                    break;
                case 'D':
                    data.TryGetValue("D", out n);
                    break;
                case 'M':
                    data.TryGetValue("M", out n);
                    break;
            }
            return n;
        }
    }
}
