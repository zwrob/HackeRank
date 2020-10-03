using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    public static class CamelCase
    {
        public static int camelcase(string s)
        {

            List<string> list = new List<string>();
            var d = s.Select((letter, index) => new { letter, index }).Where(x => x.letter == Char.ToUpper(x.letter)).ToList();
            int idx = 0;
            for (int i = 0; i <= d.Count; i++)
            {
                
                if (i == d.Count)
                {
                    string word = s.Substring(idx);
                    list.Add(word);
                }
                else
                {
                    list.Add(s.Substring(idx, d[i].index - idx));
                    idx = d[i].index;
                }
            }


            return list.Count;
        }
    }
}
