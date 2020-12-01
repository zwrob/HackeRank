using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    //https://www.hackerrank.com/challenges/two-characters/problem
    public static class Alternate
    {
        public static int alternate(string s)
        {

            var d = s.Distinct().ToList();
            // teraz trzeba utworzyc kombinacje dwuliterowe

            return 0;
        }


        public static int alternate_(string s)
        {

            var d = s.Distinct().ToList();

            return remove(s, d); 
        }

        private static int ilePar(string s)
        {
            int w = s.Length;
            if (s.Length < 3) { return w; }
            else
            {
                string c = s.Substring(0, 2);

                for (int i = 2; i < s.Length; i++)
                {
                    if (s[i] != s[i-2]) { return 0; }
                }
            }

            return w;
        }

        private static int remove(string s,List<char> d)
        {
            int r = 0;
            if (s.Length > 1 && d.Count > 1)
            {
                foreach (char c in d)
                {
                    string ns = s.Replace(c.ToString(), "");
                    int ile = ilePar(ns);

                    char[] a = new char[d.Count];
                    d.CopyTo(a);
                    List<char> b = a.ToList();
                    b.Remove(c);
                    int g = remove(ns,b);

                    if (g > ile ) { ile = g; }
                    if (ile > r) { r = ile; }
                }
            }
          
            return r;
        }
    }
}
