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

    // Complete the arrayManipulation function below.
    static long arrayManipulation(int n, int[][] queries)
    {
        int left = 0;
        int right = 0;
        int value = 0;
        int max = 0;
        int[] visited = new int[n+1];
        for (int i = 0; i <= n; ++i)
            visited[i] = 0;

        for(int i=0;i<queries.Length; ++i)
        {
            left = queries[i][0];
            right = queries[i][1];
            value = queries[i][2];
            visited[left] += value;
            if(right + 1 <= n)
                visited[right + 1] -= value;
        }
        value = 0;
        for(int i=0;i<=n;++i)
        {
            value += visited[i];
            if (max < value)
                max = value;
        }
        return max;
    }

    static void Main(string[] args)
    {
        string[] nm = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nm[0]);

        int m = Convert.ToInt32(nm[1]);

        int[][] queries = new int[m][];

        for (int i = 0; i < m; i++)
        {
            queries[i] = Array.ConvertAll(Console.ReadLine().Split(' '), queriesTemp => Convert.ToInt32(queriesTemp));
        }

        long result = arrayManipulation(n, queries);

    }
}
