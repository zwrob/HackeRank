using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    public static class SherlockAndAnagrams
    {
        // https://www.hackerrank.com/challenges/sherlock-and-anagrams/problem

        public static int sherlockAndAnagrams(string s)
        {
            int result = 0;
            Dictionary<string, int> dict = new Dictionary<string, int>();
            for (int i = 0; i < s.Length; i++) 
            {
                for (int j = 1; j <= s.Length - i  ; j++) 
                {
                    string txt = new String(s.Substring(i,j).OrderBy(x => x).ToArray());
                    if (dict.ContainsKey(txt)) { dict[txt]++; }
                    else
                    {
                        dict.Add(txt, 1);
                    }
                }
            }
            foreach (var map in dict)
            {
                result += (map.Value - 1) * map.Value;
            }

            return result / 2;
        }

        private static string ReverseString(string srtVarable)
        {
            return new string(srtVarable.Reverse().ToArray());
        }

      

    }
}
