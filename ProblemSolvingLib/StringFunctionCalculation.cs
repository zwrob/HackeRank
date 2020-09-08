using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    public static class StringFunctionCalculation
    {
        // https://www.hackerrank.com/challenges/string-function-calculation/problem
        public static int MaxValueTimeOut(string t)
        {
            // działa ale nie przechodzi testu wydajności
            int result = 0;
            for (int i = 1; i <= t.Length; i++)
            {
                Dictionary<string, int> dict = new Dictionary<string, int>();
                for (int j = 0; j < t.Length - i + 1; j++)
                {
                    string txt = t.Substring(j, i);
                    if (dict.ContainsKey(txt)) { dict[txt] += txt.Length; }
                    else
                    {
                        dict.Add(txt, txt.Length);
                    }
                }
                int max = dict.Select(x => x.Value).Max();
                if (max > result) { result = max; }
            }
            return result;
        }


        public static int MaxValue(string t)
        {
            Node root = new Node();

            void AddSuffix(Node node,string text)
            {
               
                var suf = node.Children.FirstOrDefault(x => x.Key.IndexOf(text) == 0);
                if (suf.Key == null )
                {
                    node.Children.Add(text, null);
                }
                else
                {
                    var tt = 0;
                }
                    
            }


            for (int i = 0; i < t.Length; i++)
            {
                AddSuffix(root,$"{t.Substring(i)}");
            }

            return root.Children.Count ;
        }

        private static void AddSuffix(string text)
        {

        }
    }

   

    public class Node
    {
        public Dictionary<string, Node> Children { get; set; }
        public bool IsCompleteWord { get; set; }

        public Node()
        {
            Children = new Dictionary<string, Node>();
        }
    }
}
// sufiix tree znajdłuje najdłuższe słowo wewnątrz slowa
///https://stackoverrun.com/pl/q/2734822
///
// http://smurf.mimuw.edu.pl/book/export/html/568  Algorytm Ukkonena
// https://www.youtube.com/watch?v=N70NPX6xgsA   na podstawie tej animacji