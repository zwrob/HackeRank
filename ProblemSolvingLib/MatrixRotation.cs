using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    public class Point
    {
        public int R { get; set; }
        public int C { get; set; }
        public int Value { get; set; }

        public Point(int r, int c, int value)
        {
            this.R = r;
            this.C = c;
            this.Value = value;
        }
    }

    public static class MatrixRotation
    {

        public static string matrixRotation(List<List<int>> matrix, int rotations)
        {
            // https://www.hackerrank.com/challenges/matrix-rotation-algo/problem

            int lngRow = matrix.Count;
            int lngCol = (lngRow == 0) ? 0 : matrix[0].Count;

            List<List<int>> result = new List<List<int>>();
            matrix.ForEach(x => result.Add(new List<int>(x.Select(y => 0))));

            //----- zrobic pętlę zwiększającą r i c do momentu gdy oo = 0
            List<List<Point>> pointsList = new List<List<Point>>();

            int c = 0, r = 0;
            int ile = (int)( (Math.Ceiling((decimal)lngCol/2)<Math.Ceiling((decimal)lngRow/2) ) ?
                  Math.Ceiling((decimal)lngCol/2) : Math.Ceiling((decimal)lngRow/2));
            for (int i = 0; i < ile; i++)
            {
                var g = matrix[r].Select((item, index) => new { item, index }).Where(x => x.index >= c && x.index < lngCol - c).
                Select(z => /* new { item = z.item , row = r ,col =  z.index }*/ new Point(r, z.index, z.item)).ToList();

                var p = matrix.Select((item, index) => new { item, index }).Where(x => x.index > r && x.index < lngRow - r).
                  Select(z => /*new { item = z.item[lngCol - c - 1] ,row = z.index, col = lngCol - c - 1 }*/
                  new Point(z.index, lngCol - c - 1, z.item[lngCol - c - 1]));

                var d = matrix[lngRow - r - 1].Select((item, index) => new { item, index }).Where(x => x.index >= c && x.index < lngCol - c - 1).
                   OrderByDescending(y => y.index).Select(z => /*new { z.item ,row = lngRow - r - 1, col = z.index }*/
                   new Point(lngRow - r - 1, z.index, z.item));

                var l = matrix.Select((item, index) => new { item, index }).Where(x => x.index > r && x.index < lngRow - r - 1).
                    OrderByDescending(y => y.index).Select(z => /* new {item =  z.item[c] ,row = z.index, col = c} */
                    new Point(z.index, c, z.item[c]));

                List<Point> lp = new List<Point>();

                lp.AddRange(g);
                lp.AddRange(p);
                lp.AddRange(d);
                lp.AddRange(l);

                pointsList.Add(lp);

                c++; r++;
            }

            //--------------------------------

            for (int i = 0; i < pointsList.Count; i++)
            {
         
                //rotacja
                pointsList[i] = rotateList(pointsList[i],rotations);
                //wstawienie nowych wartosci do matrix
                pointsList[i].ForEach(x => result[x.R][x.C] = x.Value);
            }

            StringBuilder strREsult = new StringBuilder();
            //  foreach(var line in result)
            for (int i = 0;  i < result.Count; i++)
            {
                string ln = "";
                result[i].ForEach(x => ln += $" {x}");
                ln = ln.TrimStart();
                strREsult.AppendLine(ln);
                Console.WriteLine(ln);
            }

            return strREsult.ToString();
        }

        private static List<Point> rotateList(List<Point> list, int rotations)
        {
     
            int rot = rotations - list.Count *(rotations / list.Count);
            List<int> copy = new List<int>( list.GetRange(0, rot).Select(x => x.Value));
            int nr = list.Count - rot;
            for (int i = 0; i < list.Count ; i++)
            {
                if (i < nr)
                {
                    list[i].Value = list[i + rot].Value;
                }
                else
                {
                    list[i].Value = copy[i - nr];
                }
            }
            return list;
        }
    }
}
