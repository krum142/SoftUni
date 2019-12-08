using System;
using System.Linq;
namespace FroggyJump
{
    class Program
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var jumps = new Lake(input);

            Console.WriteLine(string.Join(", ", jumps));
        }
    }
}
