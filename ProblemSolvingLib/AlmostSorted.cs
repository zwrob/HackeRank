using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    public static class AlmostSorted
    {
        // https://www.hackerrank.com/challenges/almost-sorted/problem
        public static void almostSorted(int[] arr)
        {
            string l1="no", l2="";
            List<int> sorted = arr.ToList();
            sorted.Sort();

            var tt = arr.Select((v,i)=>new {v,i }).Where(x=>sorted[x.i]!=x.v).ToList();

            var min = tt.Min(x => x.i);
            var max = tt.Max(x => x.i);
            var diff = arr.Select((v, i) => new { v, i }).Skip(min).Take(max - min).ToList();
            //------ liczba 414619  gubi sie w diff !!! dlatego diff musi być zakresem od do na arr !!!
            int h = sorted[41401];
            var hh = arr.Select((v, i) => new { v, i }).Where(x => x.v == 414619);
            var khh = diff.Where(x => x.v == 414619);
            var tth = tt.Where(x => x.v == 414619);
            int j = tt.Count();
            //--------
            if (diff.Count() == 0) { l1 = "yes"; }
           else
            {
                // sprawdzic rewerse - odwrócenie tablicy np 5432 na 2345 lub swap - zamiana np 4 3 2 na 2 3 4
                var diffRev = diff.OrderByDescending(x => x.i).Select(y => y.v).ToList();
                int idxStart = diff[0].i;
                int take = diff.Count;
                int idxEnd = diff[take - 1].i;
                var sordetSub = sorted.Skip(idxStart).Take(take).ToList();

                var f1 = sordetSub[sordetSub.Count - 1];
                var f2 = diffRev[diffRev.Count - 1];

                for(int i =0;i< sordetSub.Count;i++)
                {
                    if (sordetSub[i] != diffRev[i]) { int g = i; }//liczba 414619 jest w sortedSub a nie ma w diffRev, i=4056
                }

                if (Enumerable.SequenceEqual<int>(sordetSub, diffRev))
                {
                    l1 = "yes";
                    l2 = $"reverse {idxStart+1} {idxEnd +1}";
                }
               
            }
            //         // testcase 19  : reverse 37346 45458
            Console.WriteLine(l1);
            if (!string.IsNullOrEmpty(l2))
            {
                Console.WriteLine(l2);
            }
        }
    }
}
