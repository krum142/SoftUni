using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var arr = new int[n, n];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                var Input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = Input[j];
                }
            }
            int first = 0;
            int second = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        first += arr[i, j];
                    }
                }
            }

            for (int i = 0, y = n - 1; i < n; i++, y--)
            {
                second += arr[i, y];
            }
            Console.WriteLine(Math.Abs(first - second));

        }
    }
}