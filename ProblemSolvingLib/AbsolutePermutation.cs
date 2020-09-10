using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    public static class AbsolutePermutation
    {
        // https://www.hackerrank.com/challenges/absolute-permutation/problem

        public static int[] absolutePermutation(int n, int k)
        {
            //https://www.geeksforgeeks.org/k-difference-permutation/

            int[] arr = new int[n];

            if (k == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    arr[i] = i + 1;
                }
            }
            else if (n % (2 * k) != 0) { arr = new int[1] { -1 }; }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    if ((i / k) % 2 == 0)
                    {
                        arr[i] = i + k + 1;
                    }
                    else
                    {
                        arr[i] = i - k + 1;
                    }
                }
            }
            return arr;

        }
    }
}
