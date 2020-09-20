using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    public static class HappyLadybugs
    {
        // https://www.hackerrank.com/challenges/happy-ladybugs/problem

        public static string happyLadybugs(string b)
        {

            var groups = b.GroupBy(x => x).Select(x => new { letter= x.Key, count = x.Count() });

            var ff = groups.Where(x => x.letter == '_').Count();
            var fff = groups.Where(x => x.letter != '_' && x.count < 2).Count();

            if (ff == 0 && b.Length>1 && fff == 0)
            {
                int il = 1;
                for (int i = 1; i < b.Length; i++)
                {
                    il++;
                    if (b[i] != b[i-1])
                    { 
                        if (il-1 < 2) { return "NO"; }
                        else { il = 1; }
                    }
                }
                return "YES";
            }


           if (fff == 0 && (ff>0 || (ff==0 && groups.Count() == 1) )) { return "YES"; }
            return "NO";

        }
    }
}
