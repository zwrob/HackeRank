using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    public static class ClosestNumbers
    {
        public static int[] closestNumbers(int[] arr)
        {
            List<int> result = new List<int>();
            var sorted = arr.OrderBy(x => x).ToList();
            int minDiff = int.MaxValue;
            for(int i = 1; i < sorted.Count; i++)
            {
                int diff = Math.Abs(sorted[i] - sorted[i - 1]);
                if (diff <= minDiff)
                {
                    if (diff < minDiff)
                    {
                        minDiff = diff;
                        result.Clear();
                    }

                    result.Add(sorted[i - 1]);
                    result.Add(sorted[i]);
                }
            }
            return result.ToArray();

        }
    }
}
