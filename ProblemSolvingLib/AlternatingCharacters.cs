using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    public static class AlternatingCharacters
    {
        // https://www.hackerrank.com/challenges/alternating-characters/problem

        public static int alternatingCharacters(string s)
        {
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (i > 0 && s[i] == s[i-1])
                {
                    result++;
                }

            }
            return result;
        }
    }
}
