using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var command = input[0];

                if (command == "1")
                {
                    var num = int.Parse(input[1]);
                    stack.Push(num);
                }
                else if (command == "2")
                {
                    if (!(stack.Count == 0))
                    {
                        stack.Pop();
                    }
                }
                else if (command == "3")
                {
                    if (!(stack.Count == 0))
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (command == "4")
                {
                    if (!(stack.Count == 0))
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }
            Console.WriteLine(string.Join(", ", stack));
        }
    }
}