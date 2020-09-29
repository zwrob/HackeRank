using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace ProblemSolvingLib
{
    public class BigSorting
    {
        public static string[] bigSorting(string[] unsorted)
        {
            // https://www.hackerrank.com/challenges/big-sorting/problem

          Array.Sort(unsorted, (string a, string b) => {
                if (a.Length == b.Length)
                    return string.Compare(a, b, StringComparison.Ordinal);
                return a.Length - b.Length;
            });

            return unsorted;

        }

    }
}
