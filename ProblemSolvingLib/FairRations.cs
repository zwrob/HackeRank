using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    public static class FairRations
    {
        //https://www.hackerrank.com/challenges/fair-rations/problem
        public static int fairRations(int[] B)
        {
            int oddity = 0, count = 0;

            for (int i = 0; i < B.Length; i++)
            {
                if (B[i] % 2 != 0)
                {
                    count++;
                    oddity = (count % 2 != 0) ? oddity - i : oddity + i;
                }
            }
            return (count % 2 !=0 )? -1 : (oddity * 2);
            

        }

    }
}

