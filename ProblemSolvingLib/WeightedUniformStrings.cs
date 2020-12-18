using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    // https://www.hackerrank.com/challenges/weighted-uniform-string/problem
    public static class WeightedUniformStrings
    {
        // nie mieści się w czasie i ma błędne wartosc !!
        public static string[] weightedUniformStrings_(string s, int[] queries)
        {
            string[] result = Enumerable.Repeat("No", queries.Length).ToArray();
            List<int> ff = queries.ToList();
            int min = ff.Min();
            int ctr = 0;
            for (int i = 0; i < s.Length; i++)
            {
                ctr = (i + 1 != s.Length && s[i + 1] == s[i]) ? (ctr + 1) : 1;
                int sc = CharToInt(s[i]) * ctr;
                if (sc >= min)
                {
                    int idx = ff.IndexOf(sc);
                    if (idx > -1) { result[idx] = "Yes"; }
                }

              
            }
            return result;
        }

        // nie przechodzi niektórych testów (będne warotsci)
        public static string[] weightedUniformStrings(string s, int[] queries)
        {
            string[] result = Enumerable.Repeat("No", queries.Length).ToArray();
            Dictionary<char, int> charsLength = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (charsLength.ContainsKey(c)) { charsLength[c] += 1;  }
                else { charsLength.Add(c, 1);  }
            }

            for(int i =0;i < queries.Length; i++)
            {
                var ffg = charsLength.Where(x => queries[i] % CharToInt(x.Key) == 0);
                int gg = CharToInt('b');

                var ff = charsLength.Where(x=>queries[i] % CharToInt(x.Key) == 0 && CharToInt(x.Key)*x.Value >= queries[i]);
                if (ff.Count() > 0) { result[i] = "Yes"; }
            }

            return result;
        }

       

        private static int CharToInt(char c)
        {
            return  (int)c - 96;
        }


    }
}
