using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    // var dd = G[g].Split(new string[] { P[p] }, StringSplitOptions.None);
    public static class GridSearch
    {
        public static string Search(string[] G, string[] P)
        {
            //https://www.hackerrank.com/challenges/the-grid-search/problem

            Dictionary<int, IEnumerable<int>> indxs = new Dictionary<int, IEnumerable<int>>();
            for (int g = 0; g < G.Length; g++)
            {

                //  var lstIdx = Regex.Matches(G[g], P[0]).Cast<Match>().Select(m => m.Index);
                var lstIdx = AllIndexes(G[g], P[0]);
                if (lstIdx.Count() > 0)
                {
                    indxs.Add(g, lstIdx);
                }
            }
            foreach (var r in indxs)
            {
                foreach (var k in r.Value)
                {
                    if (Test(G,P,r.Key,k)) {  return "YES"; }
                }
            }

            return "NO";
        }

        private static IEnumerable<int> AllIndexes(string sourceString, string subString)
        {
            List<int> result = new List<int>();
            int ln = subString.Length;
            for (int i=0; i<sourceString.Length - ln+1; i++)
            {
                if (sourceString.Substring(i, ln) == subString)
                {
                    result.Add(i);
                }
            }

            return result;
        }

        private static bool Test(string[] G, string[] P,int r,int k)
        {
            bool result = true;
            for (int i = 0; i < P.Length; i++)
            {
                result = result && (G[i + r].Substring(k, P[i].Length)==P[i]);
            }

            return result;
        }
    }
}
