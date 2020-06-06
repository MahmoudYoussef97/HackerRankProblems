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

    // Complete the maximumToys function below.
    static int maximumToys(int[] prices, int k)
    {
        long currentTotalPrice = 0;
        int maximumNumberOfToys = 0;
        Array.Sort(prices);
        foreach (var price in prices)
        {
            currentTotalPrice += price;
            if (currentTotalPrice > k)
                break;
            else
                maximumNumberOfToys++;
        }
        return maximumNumberOfToys;
    }

    static void Main(string[] args)
    {
        string[] nk = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nk[0]);

        int k = Convert.ToInt32(nk[1]);

        int[] prices = Array.ConvertAll(Console.ReadLine().Split(' '), pricesTemp => Convert.ToInt32(pricesTemp))
        ;
        int result = maximumToys(prices, k);
    }
}
