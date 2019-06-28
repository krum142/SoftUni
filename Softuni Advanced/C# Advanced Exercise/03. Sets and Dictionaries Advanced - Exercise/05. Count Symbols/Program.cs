using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var Sdictionary = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {

                if (!Sdictionary.ContainsKey(input[i]))
                {
                    Sdictionary.Add(input[i], 0);
                }

                Sdictionary[input[i]]++;
            }
            foreach (var item in Sdictionary)
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
