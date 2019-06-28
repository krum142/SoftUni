using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var MatSpecs = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var arr = new int[MatSpecs[0], MatSpecs[1]];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                var MatrixInput = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = MatrixInput[j];
                }
            }
            var List = new List<int>();
            var BiggestSum = int.MinValue;
            int ii = 0;
            int jj = 0;
            for (int i = 0; i < arr.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < arr.GetLength(1) - 2; j++)
                {
                    var one = arr[i, j];
                    var two = arr[i, j + 1];
                    var three = arr[i, j + 2];

                    var one1 = arr[i + 1, j];
                    var two1 = arr[i + 1, j + 1];
                    var three1 = arr[i + 1, j + 2];

                    var one2 = arr[i + 2, j];
                    var two2 = arr[i + 2, j + 1];
                    var three2 = arr[i + 2, j + 2];

                    var sum = one + two + three + one1 + two1 + three1
                        + one2 + two2 + three2;

                    if (sum > BiggestSum)
                    {
                        BiggestSum = sum;
                        ii = i;
                        jj = j;
                    }
                }
            }
            Console.WriteLine($"Sum = {BiggestSum}");
            Console.WriteLine($"{arr[ii, jj]} {arr[ii, jj + 1]} {arr[ii, jj + 2]}");
            Console.WriteLine($"{arr[ii + 1, jj]} {arr[ii + 1, jj + 1]} {arr[ii + 1, jj + 2]}");
            Console.WriteLine($"{arr[ii + 2, jj]} {arr[ii + 2, jj + 1]} {arr[ii + 2, jj + 2]}");

        }
    }
}
