using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class AddBinary
    {
        public static void DisplaySolution()
        {
            Console.WriteLine(Solution("11", "1"));
            Console.WriteLine(Solution("1010", "1011"));
        }

        private static string Solution(string a, string b)
        {
            if (a.Length < b.Length)
            {
                string s = a;
                a = b;
                b = s;
            }

            int[] a1 = new int[a.Length];
            int[] b1 = new int[b.Length];

            for (int i = 0; i < a1.Length; i++)
                a1[i] = a[i] - '0';
            for (int i = 0; i < b1.Length; i++)
                b1[i] = b[i] - '0';

            int index = b1.Length - 1;
            string temp = "";
            int t = 0;

            for (int i = a1.Length - 1; i >= 0; i--)
            {
                if (index >= 0)
                {
                    int n = a1[i] + b1[index] + t; 

                    temp += (n % 2);
                    t = n / 2;

                    index--;
                }
                else
                {
                    int n = a1[i] + t;

                    temp += (n % 2);
                    t = n / 2;
                }
            }

            if (t == 1)
                temp += "1";

            string res = "";
            for (int i = temp.Length - 1; i >= 0; i--)
                res += temp[i];

            return res;
        }
    }
}
