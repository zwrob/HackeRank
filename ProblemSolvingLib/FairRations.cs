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
            int result = 0;
            int length = B.Length;
            do
            {
                for (int i = 0; i < length; i++)
                {
                    if (B.Where(x => x % 2 != 0).Count() == 0) return result;
                }
            } while (B.Where(x => x % 2 != 0).Count() > 0);
            /*
            for (int i = B.Length-1; i >=0 ; i--)
            {

                if (i > 0 && B[i - 1] % 2 != 0)
                {
                    result++; B[i - 1]++;
                    if (B.Where(x => x % 2 != 0).Count() == 0) return result;
                }

                if (B[i] % 2 != 0)
                {
                    result++; B[i]++;
                    if (B.Where(x => x % 2 != 0).Count() == 0) return result;
                }

                if (i < B.Length - 1 && B[i + 1] % 2 != 0)
                {
                    result++; B[i + 1]++;
                    if (B.Where(x => x % 2 != 0).Count() == 0) return result;
                }



            } */
            return result;
        }

    }
}

