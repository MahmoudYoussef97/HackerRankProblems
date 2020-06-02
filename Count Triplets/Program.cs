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

    // Complete the countTriplets function below.
    static long countTriplets(List<long> arr, long r)
    {
        long numberOfTriplets = 0;
        Dictionary<long, long> freq = new Dictionary<long, long>();
        long size = arr.Count;
        long oldValue = 0;
        long newValue = 0;
        if (r == 1)
            return (size*(size-1)*(size-2))/(3*2*1);

        foreach (var item in arr)
        {
            if (freq.ContainsKey(item))
            {
                 oldValue = freq[item];
                 newValue = oldValue + 1;
                 freq.Remove(item);
                 freq.Add(item, newValue);
            }
            else
                freq.Add(item, 1);
        }
        
        long[] newArray = arr.ToArray();
        for(int i=0;i<newArray.Length;++i)
        {
            long tmp1 = newArray[i] * r;
            long tmp2 = newArray[i] * r * r;
            if (!freq.ContainsKey(tmp1) || !freq.ContainsKey(tmp2) || freq[tmp1] == 0 || freq[tmp2] == 0)
            {
                 oldValue = freq[newArray[i]];
                 newValue = oldValue - 1;
                 freq.Remove(newArray[i]);
                 freq.Add(newArray[i], newValue);
                 continue;
            }
            numberOfTriplets += freq[tmp2] * freq[tmp1];
             oldValue = freq[newArray[i]];
             newValue = oldValue - 1;
             freq.Remove(newArray[i]);
             freq.Add(newArray[i], newValue);
        }

        return numberOfTriplets;
    }

    static void Main(string[] args)
    {

        string[] nr = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(nr[0]);

        long r = Convert.ToInt64(nr[1]);

        List<long> arr = File.ReadAllText("C:\\Users\\mr_ho\\Desktop\\test.txt").TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt64(arrTemp)).ToList();

        long ans = countTriplets(arr, r);
        Console.WriteLine(ans);
    }
}
