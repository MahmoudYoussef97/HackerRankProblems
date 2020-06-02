using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the freqQuery function below.
    static List<int> freqQuery(List<List<int>> queries)
    {
        Dictionary<int, int> freq = new Dictionary<int, int>();
        Dictionary<int, int> maxFreq = new Dictionary<int, int>();
        List<int> result = new List<int>();
        foreach (var operations in queries)
        {
            int op = operations[0];
            int number = operations[1];
            int max = 0;
            int oldMaxFreqValue = 0;
            int oldValue = 0;
            bool found = false;
            // Insert Operation
            if (op == 1)
            {
                if(!freq.ContainsKey(number))
                {
                    freq.Add(number, 1);
                    max = freq[number];
                    if (!maxFreq.ContainsKey(max))
                        maxFreq.Add(max, 1);
                    else
                    {
                        oldMaxFreqValue = maxFreq[max];
                        oldMaxFreqValue++;
                        maxFreq.Remove(max);
                        maxFreq.Add(max, oldMaxFreqValue);
                    }
                }
                else 
                {
                    oldValue = freq[number];
                    oldValue++;
                    freq.Remove(number);
                    freq.Add(number, oldValue);
                    max = oldValue;
                    if (!maxFreq.ContainsKey(max))
                        maxFreq.Add(max, 1);
                    else
                    {
                        oldMaxFreqValue = maxFreq[max];
                        oldMaxFreqValue++;
                        maxFreq.Remove(max);
                        maxFreq.Add(max, oldMaxFreqValue);
                    }
                }
            }
            // Delete Operation
            else if(op == 2)
            {
                if (!freq.ContainsKey(number)) continue;
                else
                {
                    oldValue = freq[number];
                    max = oldValue;
                    oldValue--;
                    freq.Remove(number);
                    oldMaxFreqValue = maxFreq[max];
                    oldMaxFreqValue--;
                    maxFreq.Remove(max);
                    if (oldMaxFreqValue != 0) maxFreq.Add(max, oldMaxFreqValue);
                    if (oldValue != 0) freq.Add(number, oldValue);
                }
            }
            else
            {
                foreach (var item in maxFreq)
                {
                    if(item.Key >= number)
                    {
                        found = true;
                        break;
                    }
                }
                if (found) result.Add(1);
                else result.Add(0);
            }
        }
        return result;
    }

    static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < q; i++)
        {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        List<int> ans = freqQuery(queries);

    }
}
