using System;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var sizeOfArray = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var arr = new string[sizeOfArray[0], sizeOfArray[1]];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = input[j];
                }
            }
            int sqareMatrix = 0;
            for (int i = 0; i < arr.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 1; j++)
                {
                    var zero = arr[i, j];
                    var one = arr[i, j + 1];
                    var two = arr[i + 1, j];
                    var three = arr[i + 1, j + 1];
                    if (zero == one && one == two && two == three && three == zero)
                    {
                        sqareMatrix++;
                    }
                }
            }
            Console.WriteLine(sqareMatrix);
        }
    }
}
