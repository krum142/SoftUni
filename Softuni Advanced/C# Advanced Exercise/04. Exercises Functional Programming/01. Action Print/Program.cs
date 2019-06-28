using System;
using System.Linq;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Action<string[]> action = Print;
            action(names);
        }

        public static void Print(string[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
