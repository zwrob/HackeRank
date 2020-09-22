using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingLib
{
    public class FreqQuery
    {
        // Complete the freqQuery function below.
        public static List<int> freqQuery(List<List<int>> queries)
        {
            // https://www.hackerrank.com/challenges/frequency-queries/problem
            Dictionary<int, int> valueToFreq = new Dictionary<int, int>();
            Dictionary<int, int> freqToOccurrence = new Dictionary<int, int>();
            List<int> frequencies = new List<int>();
    

            foreach (List<int> query in queries)
            {
                int key = query[0];
                int value = query[1];

                if (key == 3)
                {
                    if (value == 0) { frequencies.Add(1); }
                    frequencies.Add((freqToOccurrence.ContainsKey(value)) ? 1 : 0);
                }
                else
                {
                    int  oldFreq = (valueToFreq.ContainsKey(value))? valueToFreq[value] : 0;
                    int oldOccurrence = (freqToOccurrence.ContainsKey(oldFreq)) ? freqToOccurrence[oldFreq] : 0;

                    int newFreq = (key == 1) ? (oldFreq + 1) : (oldFreq - 1);

                    int  newOccurrence = (freqToOccurrence.ContainsKey(newFreq))? freqToOccurrence[newFreq] : 0;

                    if (newFreq < 1)
                    {
                        valueToFreq.Remove(value);
                    }
                    else
                    {
                        valueToFreq[value] =  newFreq;
                    }

                    if ((oldOccurrence - 1) < 1)
                    {
                        freqToOccurrence.Remove(oldFreq);
                    }
                    else
                    {
                        freqToOccurrence[oldFreq] = oldOccurrence - 1;
                    }
                    freqToOccurrence[newFreq] =  newOccurrence + 1;

                }
            }

            return frequencies;
        }
    }
}
