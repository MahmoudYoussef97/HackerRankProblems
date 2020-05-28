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

    // Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c)
    {
        int start = 0;
        int end = c.Length-1;
        int minNumberOfJumps = 0;
        while(start < end)
        {   
            if (start + 2 <= end)
            {   
                if(c[start + 2] == 0)
                {
                    start += 2;
                    minNumberOfJumps++;
                }
                else if (c[start + 1] == 0)
                {
                    start += 1;
                    minNumberOfJumps++;
                }
            }
            else if(start + 1 <= end)
            {
                if (c[start + 1] == 0)
                {
                    start += 1;
                    minNumberOfJumps++;
                }
            }
        }
        return minNumberOfJumps;
    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] c = Array.ConvertAll(Console.ReadLine().Split(' '), cTemp => Convert.ToInt32(cTemp))
        ;
        int result = jumpingOnClouds(c);

    }
}
