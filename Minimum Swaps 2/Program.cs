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
    // Complete the minimumSwaps function below.
    static int minimumSwaps(int[] arr)
    {
        Dictionary<int, int> nodes = new Dictionary<int, int>();
        bool[] isVisited = new bool[arr.Length+1];
        int minimumNumberOfSwaps = 0;

        for (int i = 1; i <= arr.Length; ++i)
            isVisited[i] = false;

        for (int i = 0; i < arr.Length; ++i)
            nodes.Add(arr[i], i+1);

        for(int i=0; i<arr.Length; ++i)
        {
            if (isVisited[i+1] || nodes[i+1] == i+1)
                continue;

            int j = i+1;
            int numberOfCycles = 0;
            while(!isVisited[j])
            {
                isVisited[j] = true;
                numberOfCycles++;
                j = nodes[j];
            }

            if (numberOfCycles > 0)
                minimumNumberOfSwaps += numberOfCycles - 1;
        }
        return minimumNumberOfSwaps;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = minimumSwaps(arr);

    }
}
