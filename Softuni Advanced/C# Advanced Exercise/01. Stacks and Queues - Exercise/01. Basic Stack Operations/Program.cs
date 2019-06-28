using System;
using System.Collections.Generic;
using System.Linq;

namespace exercise_stacks_and_queues
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            var N = int.Parse(input[0]);
            var S = int.Parse(input[1]);
            var X = int.Parse(input[2]);

            var numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            var stack = new Stack<int>();

            for (int i = 0; i < N; i++)
            {
                stack.Push(numbers[i]);
            }
            for (int i = 0; i < S; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(stack.Min());
                }

            }
        }
    }
}
