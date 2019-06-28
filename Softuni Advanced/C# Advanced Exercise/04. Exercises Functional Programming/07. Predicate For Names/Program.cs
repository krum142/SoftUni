using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());

            Predicate<string> filterByLenght = x => x.Length <= lenght;

            Console.ReadLine()
                .Split()
                .Where(s => filterByLenght(s))
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
