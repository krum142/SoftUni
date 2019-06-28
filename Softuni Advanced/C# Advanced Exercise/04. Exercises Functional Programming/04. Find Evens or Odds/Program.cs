using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEven = x => x % 2 == 0;

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string condition = Console.ReadLine();
            List<int> result = new List<int>();

            Enumerable.Range(numbers[0], numbers[1] - numbers[0] + 1)
                .Where(x=>condition == "even" ? isEven(x):!isEven(x))
                .ToList()
                .ForEach(result.Add);

            Console.WriteLine(string.Join(" ", result));
        }
    }
}
