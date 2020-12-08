using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    public static class TutorialChallanges
    {
        // https://www.hackerrank.com/challenges/tutorial-intro/problem
        public static int introTutorial(int V, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++){
                if (V == arr[i]) { return i; }
            }
            return 0;
        }
    }
}
