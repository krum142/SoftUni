using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < number; i++)
            {
                var input = int.Parse(Console.ReadLine());

                if (!dictionary.ContainsKey(input))
                {
                    dictionary.Add(input, 0);
                }

                dictionary[input]++;

            }
            foreach (var item in dictionary)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}