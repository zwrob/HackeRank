using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    public static class AlternateString
    {
        //https://www.hackerrank.com/challenges/two-characters/problem

        public static int alternate(string s)
        {
            //hashmap
            var dist = s.OrderBy(x => x).Distinct();
            Dictionary<char, List<int>> hashmap = new Dictionary<char, List<int>>();
            foreach (char c in dist)
            {
                //TODO zastąpic IndexOfAll

                var indxs = s.Select((item, index) => new { value = item, index }).
                    Where(x => x.value == c).Select(it => it.index).ToList();
                // var indxs = s.IndexOfAll($"{c}").ToList();
                hashmap.Add(c, indxs);
            }

            var pairs = GetKCombs<char>(dist, 2);
            Dictionary<string, List<int>> dict = new Dictionary<string, List<int>>();
            List<string> l = new List<string>();
            foreach (var pair in pairs)
            {
                var p =  pair.ToArray();
                List<int> f0 = new List<int>();
                f0.AddRange(hashmap[p[0]]);
                f0.AddRange(hashmap[p[1]]);
                f0.Sort();
               

                //strawdzenie czy litery sąnaprzemienne
                bool ok = true;
                for (int i = 0; i < f0.Count; i++)
                {
                    if (!(i == 0 || s[f0[i]] != s[f0[i - 1]]))
                    {
                        ok = false;
                    }
                }

                if (ok)
                {
                    dict.Add(new string(f0.Select(x => s[x]).ToArray()), f0);
                    //  string ns = s.Replace(p[0].ToString(), "").Replace(p[1].ToString(), "");
                    //  if ( ns.Distinct().Count() % 2 == 0){
                    //dict.Add(new string(f0.Select(x => s[x]).ToArray()), f0);
                    // }
                }
               
            }
            return (dict.Count == 0) ? 0 : dict.Max(x => x.Value.Count);
        }

       
     
        private static IEnumerable<IEnumerable<T>>
         GetKCombs<T>(IEnumerable<T> list, int length) where T : IComparable
        {
            if (length == 1) return list.Select(t => new T[] { t });
            return GetKCombs(list, length - 1)
                .SelectMany(t => list.Where(o => o.CompareTo(t.Last()) > 0),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
        }

    }
}
