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

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr)
    {
        List<int> values = new List<int>();
        int hourglassSumValue = 0;
        for(int i=0;i <4; ++i)
        {
            for(int j=0; j<4; ++j)
            {
                hourglassSumValue += arr[i + 1][j + 1]
                                + arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                                + arr[i + 2][j] + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                values.Add(hourglassSumValue);
                hourglassSumValue = 0;
            }
        }
        return values.Max();
    }

    static void Main(string[] args)
    {

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++)
        {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

    }
}
