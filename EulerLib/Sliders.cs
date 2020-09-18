using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EulerLib
{
   // https://www.hackerrank.com/contests/projecteuler/challenges/euler244/problem

    public static  class Solution
    {
        static void Main(String[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            // initial array
            List<string> initialList = new List<string>();
            for (int i = 0; i < n; i++)
            {
                initialList.Add(Console.ReadLine());
            }

            //final array
            List<string> finalList = new List<string>();
            for (int i = 0; i < n; i++)
            {
                finalList.Add(Console.ReadLine());
            }

            long result = CalculateMinimalLength(initialList, finalList);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();

        }

        public static long CalculateMinimalLength(List<string> initial, List<string> final)
        {
            Sliders sliders = new Sliders(initial, final);

            return sliders.CalculateMinimalLength(); ;
        }
    }
    public class Sliders
    {
        private const int MAX_RECURSIVE_CALLS = 1500;
        static int ctr = 0;

        private readonly int maxX ;
        private readonly int maxY ;

        private readonly List<char[]> initArr;
        private readonly List<char[]> finalArr;

        private List<string> results = new List<string>();

        public Sliders(List<string> initial, List<string> final)
        {
            this.maxX = initial[0].Count();
            this.maxY = initial.Count;

            initArr = initial.Select(x => x.ToArray()).ToList();
            finalArr = final.Select(x => x.ToArray()).ToList();
        }

        private static int LetterToValue( char letter)
        {
            switch (letter)
            {
                case 'L':
                    return 76;
                case 'R':
                    return 82;
                case 'U':
                    return 85;
                case 'D':
                    return 68;
            }
            return 0;
        }

        public static long CalculateCheckSum(long checksum, char letter)
        {
            return (checksum * 243 + LetterToValue(letter)) % 100000007;
        }

        public static long CalculateCheckSum(string word)
        {
            long result = 0;
            foreach(char l in word)
            {
                result = CalculateCheckSum(result, l);
            }
            return result;
        }

        private List<char[]> CopyList(List<char[]> list)
        {
            List<char[]> result = new List<char[]>();
            list.ForEach(x => { char[] arr = new char[x.Length]; Array.Copy(x, arr, x.Length); result.Add(arr); });

            return result;
        }
        
        private bool IsFinal(List<char[]> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                bool gg = list[i].SequenceEqual(finalArr[i]);
                if ( !list[i].SequenceEqual(finalArr[i])) { return false; }

            }
            return true;
            /*
            // porównanie list z finalArr
            var rr = list.Select((item, index) => new { item, index }).
                Where(x => (new String(x.item)) == (new String(finalArr[x.index])));
     
            return (rr.Count() == list.Count);
            */
        }
        
        private bool Move(string movements, List<char[]> list) // ma zwracac liste dostępnych ruchów
        {

            if (ctr > MAX_RECURSIVE_CALLS) { return false; }
            if (movements.Length > 2*Math.Pow( list.Count,2) || 
                (this.results.Count > 0 && movements.Length > this.results.Min(x=>x.Length)) ) { return false; }

            ctr++;

            bool isFinal = IsFinal(list);
            if (!isFinal)
            {
                char lastMove = (movements.Length > 0) ? movements[movements.Length - 1] : 'x';

                // znalezienie położenia pustego elementu
                var emptyPoint = list.Select((item, index) => new { item, index }).Where(x => x.item.Contains('W')).
                    Select((item, index) => new { x = Array.IndexOf(item.item, 'W'), y = item.index }).FirstOrDefault();

                // prawo
                if (emptyPoint.x > 0 && lastMove != 'L')
                {
                    string mov = $"{movements}R";

                    List<char[]> gg = CopyList(list);
                    gg[emptyPoint.y][emptyPoint.x] = list[emptyPoint.y][emptyPoint.x- 1];
                    gg[emptyPoint.y][emptyPoint.x - 1] = list[emptyPoint.y][emptyPoint.x];
                    Move(mov, gg);
                }

                // lewo
                if (emptyPoint.x < maxX - 1 && lastMove != 'R')
                {
                    string mov = $"{movements}L";

                    List<char[]> gg = CopyList(list);
                    gg[emptyPoint.y][emptyPoint.x] = list[emptyPoint.y][emptyPoint.x + 1];
                    gg[emptyPoint.y][emptyPoint.x + 1] = list[emptyPoint.y][emptyPoint.x];
                    Move(mov, gg);
                }
                // góra
                if (emptyPoint.y < maxY - 1 && lastMove != 'D')
                {
                    string mov = $"{movements}U";

                    List<char[]> gg = CopyList(list);
                    gg[emptyPoint.y][emptyPoint.x] = list[emptyPoint.y + 1][emptyPoint.x];
                    gg[emptyPoint.y + 1][emptyPoint.x] = list[emptyPoint.y][emptyPoint.x];
                    Move(mov, gg);
                }

                // dół
                if (emptyPoint.y > 0 && lastMove != 'U')
                {
                    string mov = $"{movements}D";
                    List<char[]> gg = CopyList(list);
                    gg[emptyPoint.y][emptyPoint.x] = list[emptyPoint.y - 1][emptyPoint.x];
                    gg[emptyPoint.y - 1][emptyPoint.x] = list[emptyPoint.y][emptyPoint.x];
                    Move(mov, gg);
                }

            }
            else
            {
                // wstaienie wyniku do listy wyników
                results.Add(movements);
            }
            ctr--;
            return isFinal;
        }

        public long CalculateMinimalLength()
        {

            Move("", initArr);
            if (this.results.Count > 0)
            {
                int min = this.results.Min(maxX => maxX.Length);

                var gg = this.results.Where(x => x.Length == min).OrderBy(y => y);

                var jj = gg.Select(x => CalculateCheckSum(x)).Sum() % 100000007;

                return jj;
            }
            return 0;

        }
    }
}

