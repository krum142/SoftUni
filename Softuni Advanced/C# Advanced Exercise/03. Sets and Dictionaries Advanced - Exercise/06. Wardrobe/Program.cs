using System;
using System.Collections.Generic;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var diction = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                if (!diction.ContainsKey(input[0]))
                {
                    diction.Add(input[0], new Dictionary<string, int>());
                }

                var toAdd = input[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < toAdd.Length; j++)
                {
                    if (!diction[input[0]].ContainsKey(toAdd[j]))
                    {
                        diction[input[0]].Add(toAdd[j], 1);
                    }
                    else
                    {
                        diction[input[0]][toAdd[j]]++;
                    }
                }
            }

            var search = Console.ReadLine().Split();

            foreach (var (kay, value) in diction)
            {
                Console.WriteLine($"{kay} clothes:");

                foreach (var (kayy, vvalue) in value)
                {
                    if (kay == search[0] && kayy == search[1])
                    {
                        Console.WriteLine($"* {kayy} - {vvalue} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {kayy} - {vvalue}");
                    }
                }
            }
        }
    }
}
