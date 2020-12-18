using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EulerLib
{
    public static class PrimeSubsetSums
    {
        //https://www.hackerrank.com/contests/projecteuler/challenges/euler249/problem

        private static bool IsPrime(int n)
        {
            int m = n / 2;
            for (int i = 2; i <= m; i++)
            {
                if (n % i == 0) { return false; }
            }
            return true;
           
        }

        public static List<int> GetPrimeNumbers(int n)
        {
            List<int> result = new List<int>();

            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i)) { result.Add(i); }
            }

            return result;
        }

        //https://stackoverflow.com/questions/1952153/what-is-the-best-way-to-find-all-combinations-of-items-in-an-array
        /*
        private static IEnumerable<IEnumerable<T>>
            GetKCombs<T>(IEnumerable<T> list, int length) where T : IComparable
        {
            if (length == 1) return list.Select(t => new T[] { t });
            return  GetKCombs(list, length - 1)
                .SelectMany(t => list.Where(o => o.CompareTo(t.Last()) > 0),
                    (t1, t2) => t1.Concat(new T[] { t2 }));

        }
        */

        private static IEnumerable<IEnumerable<int>>
          GetKCombs(IEnumerable<int> list, int length, int checkedLength) 
        {
            if (length == 1) return list.Select(t => new int[] { t });

            var h = GetKCombs(list, length - 1, length)
                .SelectMany(t => list.Where(o => o.CompareTo(t.Last()) > 0),
                    (t1, t2) => t1.Concat(new int[] { t2 }));

            /*
            if (length == checkedLength)
            {
                h = h.Where(x => IsPrime(x.Sum()));
            }
            */

            return h;
        }

        public static int[] GetSubsetsInfo(int n, int m)
        {
            // pobranie liczb ierwszych oraz maksymalnej sumy w zakresie do n
            List<uint> primeNumbers = new List<uint>();
            List<int> primeNumbersToCheck = new List<int>();
            uint maxSum = 0;
            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i))
                {
                    primeNumbersToCheck.Add(i);
                    primeNumbers.Add((uint)i);
                    maxSum += (uint)i;
                }
            }

            for (int i = n + 1; i <= maxSum; i++)
            {
                if (IsPrime(i)) { primeNumbers.Add((uint)i); }
            }

            int maxSubsetLength = primeNumbersToCheck.Count;
            int primeSubsetsNumer = 0; // na początek pojedyńcze np w {2,3,5,7} => {2},{3},{5},{7}
            int primeSubsetsNumerLessThenM = 0;
            for (int substeLength = 1; substeLength <= maxSubsetLength; substeLength++)
            {
                // pobierane pszczególne długości od 1
                // np 2 z {2,3,5,7} to => {2,3},{2,5},{2,7},{3,5},{3,7},{5,7}
                // trzeba zwróccic kombinację, którj suma składników daje licznę pierwszą
                var combs = GetKCombs(primeNumbersToCheck, substeLength, substeLength);
                var f = combs.Where(x => primeNumbers.IndexOf((uint)x.Sum()) > -1);
                primeSubsetsNumer += f.Count();
            }

            return new int[2] { primeSubsetsNumer, primeSubsetsNumerLessThenM };
        }


            public static int[] GetSubsetsInfo_(int n, int m)
        {
            var primeNumbers = PrimeSubsetSums.GetPrimeNumbers(n);

            int maxSubsetLength = primeNumbers.Count;
            int primeSubsetsNumer = 0; // na początek pojedyńcze np w {2,3,5,7} => {2},{3},{5},{7}
            int primeSubsetsNumerLessThenM = 0;
            //
            for (int substeLength = 1; substeLength <= maxSubsetLength; substeLength++)
            {
                // pobierane pszczególne długości od 1
                // np 2 z {2,3,5,7} to => {2,3},{2,5},{2,7},{3,5},{3,7},{5,7}

                // trzeba zwróccic kombinację, którj suma składników daje licznę pierwszą
                var combs = GetKCombs(primeNumbers, substeLength, substeLength);
                //  var promeCombs= combs.Where(x => IsPrime( x.Sum()) );
                //  primeSubsetsNumer += promeCombs.Count();
                primeSubsetsNumer += combs.Count();

                // skladiki mniejsze od m
                primeSubsetsNumerLessThenM  += combs.Select(x => x.Where(y => y < m)).
                    Where(x=>x.Count() == substeLength).Count();

            }
            return new int[2] { primeSubsetsNumer, primeSubsetsNumerLessThenM };
        }

    }
}

//https://www.hackerrank.com/contests/projecteuler/challenges/euler235/forum
///x = d { ( 1 - (n + 1)r^n + nr^(n+1) ) / (1 - r)^2 } - a { (1 - r^n) / (1 - r) }

/*
class Solution {
    static void Main(String[] args) {

         TextWriter textWriter = new StreamWriter   (@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
         
        int k = Convert.ToInt32(Console.ReadLine());
        var array = Console.ReadLine().Split().Select(int.Parse).ToArray();
        
        var info =  GetSubsetsInfo(array[0],array[1]);
        string answer  = $"{info[0]} {info[1]}";
           
        textWriter.WriteLine(answer);

        textWriter.Flush();
        textWriter.Close();
    }
    
    static int[] GetSubsetsInfo(int n, int m)
    {
            var primeNumbers = GetPrimeNumbers(n);

            int maxSubsetLength = primeNumbers.Count;
            int primeSubsetsNumer = 0; 
            int primeSubsetsNumerLessThenM = 0;
           
            for (int substeLength = 1; substeLength <= maxSubsetLength; substeLength++)
            {
                // pobierane pszczególne długości od 1
                // np 2 z {2,3,5,7} to => {2,3},{2,5},{2,7},{3,5},{3,7},{5,7}

                // trzeba zwróccic kombinację, którj suma składników daje licznę pierwszą
                var combs = GetKCombs(primeNumbers, substeLength);
                var promeCombs= combs.Where(x => IsPrime( x.Sum()) );
                primeSubsetsNumer += promeCombs.Count();


                // skladiki mniejsze od m
                primeSubsetsNumerLessThenM  += combs.Select(x => x.Where(y => y < m)).
                    Where(x=>x.Count() == substeLength).Count();

            }
            return new int[2] { primeSubsetsNumer, primeSubsetsNumerLessThenM };
    }
    
    static bool IsPrime(int n)
    {
            int m = n / 2;
            for (int i = 2; i <= m; i++)
            {
                if (n % i == 0) { return false; }
            }
            return true;
           
    }
    
     public static List<int> GetPrimeNumbers(int n)
        {
            List<int> result = new List<int>();

            for (int i = 2; i <= n; i++)
            {
                if (IsPrime(i)) { result.Add(i); }
            }

            return result;
        }


    static IEnumerable<IEnumerable<T>>
            GetKCombs<T>(IEnumerable<T> list, int length) where T : IComparable
    {
            if (length == 1) return list.Select(t => new T[] { t });
            return GetKCombs(list, length - 1)
                .SelectMany(t => list.Where(o => o.CompareTo(t.Last()) > 0),
                    (t1, t2) => t1.Concat(new T[] { t2 }));
    }
}

 */