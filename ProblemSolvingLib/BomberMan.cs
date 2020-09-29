using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    public class BomberMan
    {
        // https://www.hackerrank.com/challenges/bomber-man/problem

        public static string[] bomberMan(int n, string[] grid)
        {
            for (int i = 2; i <= n; i++)
            {
                if (i == 2) { }
                else if ((i-3)%2 == 0) { }
                else if ((i-4)%2 == 0) { }
                
            }

            return null;
        }

    }
}
