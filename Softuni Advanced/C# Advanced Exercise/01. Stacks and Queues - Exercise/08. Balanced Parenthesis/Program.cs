using System;
using System.Collections.Generic;
using System.Linq;

namespace Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var stackOfParenteses = new Stack<char>();
            var input = Console.ReadLine()
            .ToCharArray();
            var openParenteteses = new char[] { '(', '{', '[' };
            var isValid = true;

            if (!openParenteteses.Contains(input[0]))
            {
                isValid = false;
            }
            foreach (var item in input)
            {
                if (openParenteteses.Contains(item))
                {
                    stackOfParenteses.Push(item);
                    continue;
                }

                if (stackOfParenteses.Count == 0)
                {
                    isValid = false;
                    break;
                }

                if (stackOfParenteses.Peek() == '(' && item == ')')
                {
                    stackOfParenteses.Pop();
                }
                else if (stackOfParenteses.Peek() == '{' && item == '}')
                {
                    stackOfParenteses.Pop();
                }
                else if (stackOfParenteses.Peek() == '[' && item == ']')
                {
                    stackOfParenteses.Pop();
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}