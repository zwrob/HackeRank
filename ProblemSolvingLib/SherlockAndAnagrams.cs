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
            int lMin = s.Length / 2;
            int lMax = (int)Math.Ceiling((decimal)s.Length/2);
            for (int i = 0; i < lMin; i++) 
            {
               // druga pętla dla początku teksu
               for(int j=i;j< lMin; j++)
                {

                }
            }
            return 0;
        }
    }
}
