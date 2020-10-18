using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    public static class FibonacciModified
    {
        public static BigInteger fibonacciModified(int t1, int t2, int n)
        {

            BigInteger result = 0;

            BigInteger tmin2 = (BigInteger)t1;
            BigInteger tmin1 = (BigInteger)t2;
            for (int i = 3; i <= n; i++)
            {
                result = tmin2 + tmin1 * tmin1;
                tmin2 = tmin1;
                tmin1 = result;
            }

            return result;
        }
    }
}
