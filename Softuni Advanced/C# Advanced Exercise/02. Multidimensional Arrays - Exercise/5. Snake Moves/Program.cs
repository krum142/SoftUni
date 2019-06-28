using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            var MatrixSize = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            char[,] matrix = new char[MatrixSize[0], MatrixSize[1]];

            string snake = Console.ReadLine();

            int counter = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {


                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (counter >= snake.Length)
                    {
                        counter = 0;
                    }

                    matrix[row, col] = snake[counter++];
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}