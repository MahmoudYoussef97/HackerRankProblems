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

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q)
    {
        int minBribes = 0;
        int min = q.Length;
        for (int i = q.Length-1; i >= 0; --i)
        {
            if (q[i] - i > 3)
            {
                Console.WriteLine("Too chaotic");
                return;
            }
            if (q[i] > i+1)
                minBribes += q[i] - (i + 1);
            else
            {
                if (min > q[i])
                    min = q[i];
                else if (min < q[i])
                    minBribes++;
            }          
        }
        Console.WriteLine(minBribes);
        return;
    }

    static void Main(string[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string text = File.ReadAllText("C:\\Users\\mr_ho\\Downloads\\test.txt");

            int[] q = Array.ConvertAll(text.Split(' '), qTemp => Convert.ToInt32(qTemp))
            ;
            minimumBribes(q);
        }
    }
}
