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

    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note)
    {
        Dictionary<string, int> magazineWords = new Dictionary<string, int>();
        int decrement;
        int increment;
        foreach (var word in magazine)
        {
            if (magazineWords.ContainsKey(word))
            {
                increment = magazineWords[word];
                increment++;
                magazineWords.Remove(word);
                magazineWords.Add(word, increment);
            }
            else
                magazineWords.Add(word, 1);
        }

        foreach (var word in note)
        {
            if(!magazineWords.ContainsKey(word) || magazineWords[word] <= 0)
            {
                Console.WriteLine("No");
                return;
            }
            decrement = magazineWords[word];
            decrement--;
            magazineWords.Remove(word);
            magazineWords.Add(word, decrement);
        }
        Console.WriteLine("Yes");
        return;
    }

    static void Main(string[] args)
    {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
}
