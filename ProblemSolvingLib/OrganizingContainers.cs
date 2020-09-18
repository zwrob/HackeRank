using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    public static class OrganizingContainers
    {
        public static string organizingContainers(int[][] container)
        {
            //https://www.hackerrank.com/challenges/organizing-containers-of-balls/problem
            int containerLength = container.Length;
            int[] ballsNumber = new int[containerLength];
            int[] basketCapacity = new int[containerLength];

            for (int r = 0; r < containerLength; r++)
            {
                for (int k = 0; k < containerLength; k++)
                {
                    ballsNumber[k] += container[r][k];
                    basketCapacity[r] += container[r][k];
                }
            }
            var v1 = ballsNumber.OrderBy(x => x).ToList();
            var v2 = basketCapacity.OrderBy(x => x).ToList();
            for (int i = 0; i < containerLength; i++)
            {
                if (v1[i] != v2[i]) { return "Impossible"; }
            }

            return "Possible";
        }
    }
}

