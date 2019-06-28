using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var clothes = new Stack<int>(input);

            var rackCapacity = int.Parse(Console.ReadLine());

            int MaxCapacity = 0;
            int counter = 1;

            while (clothes.Any())
            {
                var currentCloth = clothes.Peek();

                if (MaxCapacity + currentCloth <= rackCapacity)
                {
                    MaxCapacity += currentCloth;
                    clothes.Pop();
                }
                else
                {
                    MaxCapacity = 0;
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
