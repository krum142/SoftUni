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

            var queue = new Queue<int>();

            for (int i = 0; i < N; i++)
            {
                queue.Enqueue(numbers[i]);
            }
            for (int i = 0; i < S; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(X))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(queue.Min());
                }

            }
        }
    }
}