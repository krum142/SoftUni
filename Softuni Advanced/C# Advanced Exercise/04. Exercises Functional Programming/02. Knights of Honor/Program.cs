using System;
using System.Linq;

namespace _02._Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split()
                .ToArray();

            Action<string[]> action = PrintWithTitleSir;
            action(names);
        }

        private static void PrintWithTitleSir(string[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine($"Sir {name}");
            }
        }
    }
}
