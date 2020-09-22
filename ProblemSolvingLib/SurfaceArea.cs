using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    public static class SurfaceArea
    {
        // https://www.hackerrank.com/challenges/3d-surface-area/problem
        public static int surfaceArea(int[][] A)
        {
            int result = 0;
            for (int i = 0;i < A.Length; i++)
            {
                for (int j=0; j < A[i].Length ; j++)
                {
                    result += (A[i][j] * 4) + 2;
                    if (j >= 1) result -= Math.Min(A[i][j - 1], A[i][j]) * 2;
                    if (i >= 1) result -= Math.Min(A[i - 1][j], A[i][j]) * 2;
                }
            }
            return result;
        }
    }
}

