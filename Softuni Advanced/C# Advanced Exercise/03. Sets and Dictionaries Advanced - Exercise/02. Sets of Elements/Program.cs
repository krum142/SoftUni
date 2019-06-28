using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Sets_of_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var nm = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var setN = new HashSet<int>();

            var setM = new HashSet<int>();

            for (int i = 0; i < nm[0]; i++)
            {
                var input = int.Parse(Console.ReadLine());
                setN.Add(input);
            }

            for (int i = 0; i < nm[1]; i++)
            {
                var input = int.Parse(Console.ReadLine());
                setM.Add(input);
            }

            foreach (var item in setN)
            {
                if (setM.Contains(item))
                {
                    Console.Write(item + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
