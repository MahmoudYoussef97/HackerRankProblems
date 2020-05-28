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

    // Complete the repeatedString function below.
    static long repeatedString(string s, long n)
    {
        long numberOfAOccurences = 0;
        int occurences = 0;
        if(n <= s.Length)
        {
            for(int i=0; i<n; ++i)
                if (s[i] == 'a')
                    occurences++;

            return occurences;
        }
        for(int i=0; i<s.Length; ++i)
            if (s[i] == 'a')
                occurences++;

        if (n % s.Length == 0)
            return occurences * n / s.Length;
        else
        {
            numberOfAOccurences = occurences * (n / s.Length);
            for (int i = 0; i < n % s.Length; ++i)
                if (s[i] == 'a')
                    numberOfAOccurences++;
        }
        return numberOfAOccurences;
    }

    static void Main(string[] args)
    {

        string s = Console.ReadLine();

        long n = Convert.ToInt64(Console.ReadLine());

        long result = repeatedString(s, n);

    }
}
