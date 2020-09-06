using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    public static class Gemstones
    {
        // https://www.hackerrank.com/challenges/gem-stones/problem

        public static int gemstones(string[] arr)
        {

            List<char> list = null;
            for(int i=0;i<arr.Length;i++)
            {
                var distChars = arr[i].Distinct();
                if (i == 0)
                {
                    list = distChars.ToList();
                }
                else
                {
                    var notExists = list.Where(x => !distChars.Any(y=> y == x));
                   list.RemoveAll(x => notExists.Any(YieldAwaitable => YieldAwaitable == x));
                }
            }

            return (list ==null)? 0 :  list.Count;
        }

    }
}
