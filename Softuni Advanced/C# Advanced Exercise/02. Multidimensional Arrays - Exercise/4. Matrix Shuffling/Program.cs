using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            var MatSize = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var arr = new string[MatSize[0], MatSize[1]];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                var input = Console.ReadLine().Split();

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = input[j];
                }
            }

            var command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                if (command[0] == "swap" && command.Length == 5)
                {
                    var one = int.Parse(command[1]);
                    var two = int.Parse(command[2]);
                    var three = int.Parse(command[3]);
                    var four = int.Parse(command[4]);

                    bool x = Valid(arr, one, two, three, four);
                    if (x)
                    {
                        var temp = arr[one, two];
                        arr[one, two] = arr[three, four];
                        arr[three, four] = temp;

                        for (int i = 0; i < arr.GetLength(0); i++)
                        {
                            for (int j = 0; j < arr.GetLength(1); j++)
                            {
                                Console.Write($"{arr[i, j]} ");
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine($"Invalid input!");
                }
                command = Console.ReadLine().Split();
            }
        }

        private static bool Valid(string[,] arr, int one, int two, int three, int four)
        {
            if (arr.GetLength(0) >= one && one >= 0
                   && arr.GetLength(0) >= two && two >= 0
                   && arr.GetLength(0) >= three && three >= 0
                   && arr.GetLength(0) >= four && four >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
