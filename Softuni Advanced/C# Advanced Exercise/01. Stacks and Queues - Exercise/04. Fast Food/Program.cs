using System;
using System.Collections.Generic;
using System.Linq;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            var QuantityOfFood = int.Parse(Console.ReadLine());

            var orders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var queue = new Queue<int>(orders);
            var maxOrder = queue.Max();

            int counter = 0;
            foreach (var order in queue)
            {
                if (QuantityOfFood < order)
                {
                    break;
                }
                QuantityOfFood -= order;
                counter++;
            }
            for (int i = 0; i < counter; i++)
            {
                queue.Dequeue();
            }
            if (queue.Count == 0)
            {
                Console.WriteLine(maxOrder);
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine(maxOrder);
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
        }
    }
}
