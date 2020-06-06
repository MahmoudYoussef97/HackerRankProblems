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

    // Complete the countSwaps function below.
    static void countSwaps(int[] a)
    {
        int numberOfSwaps = 0;
        for(int i=0;i<a.Length;++i)
        {
            for(int j=0;j<a.Length-1;++j)
            {
                if(a[j] > a[j+1])
                {
                    Swap(a, j, j+1);
                    numberOfSwaps++;
                }
            }
        }
        Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
        Console.WriteLine($"First Element: {a[0]}");
        Console.WriteLine($"Last Element: {a[a.Length-1]}");
    }
    static void Swap(int[]a, int firstIndex, int secondIndex)
    {
        int temp = a[firstIndex];
        a[firstIndex] = a[secondIndex];
        a[secondIndex] = temp;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
        ;
        countSwaps(a);
    }
}
