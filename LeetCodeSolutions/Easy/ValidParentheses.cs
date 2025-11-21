using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSolutions.Easy
{
    internal class ValidParentheses
    {
        public static void DisplaySolution()
        {
            Console.WriteLine(Solution("()"));
            Console.WriteLine(Solution("()[]{}"));
            Console.WriteLine(Solution("(]"));
            Console.WriteLine(Solution("([])"));
            Console.WriteLine(Solution("([)]"));
        }

        private static bool Solution(string s)
        {
            if(s.Length <= 1)
                return false;

            char c;
            Stack<char> stack = new Stack<char>();

            for(int i = 0; i < s.Length; i++)
            {
                if(s[i] == '{' || s[i] == '(' || s[i] == '[')
                {
                    stack.Push(s[i]);
                    continue;
                }
                else
                {
                    if (stack.Count == 0)
                        return false;

                    c = stack.Pop();
                    if (c == '[' && s[i] != ']')
                        return false;
                    else if(c == '{' && s[i] != '}')
                        return false;
                    else if(c == '(' && s[i] != ')')
                        return false;
                }
            }

            if(stack.Count > 0)
                return false;
            return true;
        }
    }
}
