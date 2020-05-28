using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankProblems
{
    class Program
    {   
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);
            Console.WriteLine(result);
        }
        static int sockMerchant(int n, int[] ar)
        {
            Hashtable hashtable = new Hashtable();
            int count = 0;
            for (int i = 0; i < n; ++i)
            {
                if (hashtable.ContainsKey(ar[i]))
                {
                    int val = (int)hashtable[ar[i]];
                    hashtable[ar[i]] = ++val;
                }
                else
                    hashtable.Add(ar[i], 1);
            }
            for (int i = 0; i < n; ++i)
            {
                if ((int)hashtable[ar[i]] == 0)
                    continue;
                count += (int)hashtable[ar[i]] / 2;
                hashtable[ar[i]] = 0;
            }
            return count;
        }
    }
}
