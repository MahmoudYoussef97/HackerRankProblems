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

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s)
    {
        int seaLevel = 0;
        int numberOfValleys = 0;
        for(int i=0;i<n;++i)
        {
            if (s[i] == 'U')
                seaLevel++;
            else if (s[i] == 'D')
                seaLevel--;
            if (s[i] == 'U' && seaLevel == 0)
                numberOfValleys++;
        }
        return numberOfValleys;
    }
    static void Main(string[] args)
    {
        
        int n = Convert.ToInt32(Console.ReadLine());

        string s = Console.ReadLine();

        int result = countingValleys(n, s);
        Console.WriteLine(result);
    }
}
