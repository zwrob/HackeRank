using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    public static class HackerrankInString
    {
        // https://www.hackerrank.com/challenges/hackerrank-in-a-string/problem
        public static string hackerrankInString(string s)
        {
            string strToCheck = "hackerrank";
            int idx = 0;
            foreach(char c in s)
            {
                if (c == strToCheck[idx])
                {
                    if (idx == strToCheck.Length-1) { return "YES"; }
                    else { idx++; }
                
                }
            }

            return "NO";

        }

        //https://www.hackerrank.com/challenges/two-strings/problem?utm_campaign=challenge-recommendation&utm_medium=email&utm_source=24-hour-campaign
        public static string twoStrings_(string s1, string s2)
        {
            string p, q;
            if (s1.Length > s2.Length)
            {
                p = s2;q = s1;
            }
            else
            {
                p = s1;q = s2;
            }
            foreach (char c in p)
            {
                if (q.IndexOf(c)  > -1) { return "YES"; }
            }
            return "NO";
        }

        public static string twoStrings(string s1, string s2)
        {
            string letters = "abcdefghijlkmnopqrstuvwxyz";
            foreach (char c in letters)
            {
                if (s1.IndexOf(c) > -1 && s2.IndexOf(c) > -1) { return "YES"; }
            }

            return "NO";

        }


    }
}
