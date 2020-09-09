using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    public static class BiggerIsGreater
    {
        // https://www.hackerrank.com/challenges/bigger-is-greater/problem
        public static string biggerIsGreater(string w)
        {

            for (int i = w.Length - 2; i >= 0; i--)
            {
                char letterToChange =  w.Substring(i, 1)[0];
                var sub = w.Substring(i + 1);
                var lett = sub.Where(x => x > letterToChange).OrderBy(y=>y).ToArray();
                if (lett.Count() > 0)
                {
                    var minLetter = lett.Min();
                    int minIdx = sub.IndexOf(minLetter);

                    char[] chSub = sub.ToArray();
                    chSub[minIdx] = letterToChange;
                    char[] wSub = w.Substring(0, i+1).ToArray();
                    wSub[i] = minLetter;

             
                    string result = new String(wSub) + new String(chSub.OrderBy(x=>x).ToArray() );
                    return result;
                }
            }

            return "no answer";

        }
    }
}
