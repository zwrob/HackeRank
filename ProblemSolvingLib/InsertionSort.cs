using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    public static class InsertionSort
    {
        public static void insertionSort1(int n, int[] arr)
        {
            //  https://www.hackerrank.com/challenges/insertionsort1/problem
            int comp = arr[arr.Length - 1];
            int i = arr.Length - 1;

            do
            {
                i--;
                int g = (i==-1)? comp: arr[i];
                arr[i + 1] = (g > comp) ? g : comp;

                string line = "";

                foreach (int l in arr)
                {
                    line += $" {l}";
                }

                Console.WriteLine(line.TrimStart()); 
            } while ((i >= 0 && arr[i + 1] != comp));
        }
    }
}
