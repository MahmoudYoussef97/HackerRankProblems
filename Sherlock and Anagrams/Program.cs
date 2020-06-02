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

    // Complete the sherlockAndAnagrams function below.
    static int sherlockAndAnagrams(string s)
    {
        int numberOfAnagramsPairs = 0;
        Dictionary<string, int> map = new Dictionary<string, int>();
        for (int i = 0; i < s.Length; ++i)
        {
            string subs = "";
            for (int j = i; j < s.Length; j++)
            {
                subs += s[j];
                char[] tempArray = subs.ToCharArray();
                Array.Sort(tempArray);
                subs = new String(tempArray);

                if (map.ContainsKey(subs))
                {
                    int value = map[subs];
                    value++;
                    map.Remove(subs);
                    map.Add(subs, value);
                }
                else
                    map.Add(subs, 1);
            }
        }
        foreach (var item in map)
        {
            numberOfAnagramsPairs += (item.Value * (item.Value - 1)) / 2;
        }
        return numberOfAnagramsPairs;
    }

    static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine());

        for (int qItr = 0; qItr < q; qItr++)
        {
            string s = Console.ReadLine();

            int result = sherlockAndAnagrams(s);
        }

    }
}
