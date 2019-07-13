using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Snaking
{
    public class Engine
    {
        private char[][] room;
        private int rows;
        private int playerRow;
        private int playerCol;
        private int enemyRow;
        private int enemyCol;

        public Engine()
        {
            this.room = new char[][] { };
        }

        public void Run()
        {
            rows = int.Parse(Console.ReadLine());
            InitializeField();

            var directions = Console.ReadLine()?.ToCharArray();

            if (directions != null)
                for (int currentDirection = 0; currentDirection < directions.Length; currentDirection++)
                {
                    MoveEnemyPosition();
                    FindEnemyPosition();

                    bool checkResult = CheckWhetherPlayerDies();
                    if (checkResult == true)
                    {
                        room[playerRow][playerCol] = 'X';

                        Console.WriteLine($"Sam died at {playerRow}, {playerCol}");
                        PrintField();
                    }

                    MovePlayerPosition(directions, currentDirection);

                    FindEnemyPosition();

                    if (room[enemyRow][enemyCol] == 'N' && playerRow == enemyRow)
                    {
                        room[enemyRow][enemyCol] = 'X';

                        Console.WriteLine("Nikoladze killed!");
                        PrintField();
                    }
                }
        }

        private void MovePlayerPosition(char[] directions, int currentDirection)
        {
            room[playerRow][playerCol] = '.';

            switch (directions[currentDirection])
            {
                case 'U':
                    playerRow--;
                    break;
                case 'D':
                    playerRow++;
                    break;
                case 'L':
                    playerCol--;
                    break;
                case 'R':
                    playerCol++;
                    break;
            }

            room[playerRow][playerCol] = 'S';
        }

        private bool CheckWhetherPlayerDies()
        {
            bool result = false;

            if (playerCol < enemyCol && room[enemyRow][enemyCol] == 'd' && enemyRow == playerRow)
            {
                result = true;
            }
            else if (enemyCol < playerCol && room[enemyRow][enemyCol] == 'b' && enemyRow == playerRow)
            {
                result = true;
            }

            return result;
        }

        private void PrintField()
        {
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    Console.Write(room[row][col]);
                }

                Console.WriteLine();
            }

            Environment.Exit(0);
        }

        private void FindEnemyPosition()
        {
            for (int col = 0; col < room[playerRow].Length; col++)
            {
                if (room[playerRow][col] != '.' && room[playerRow][col] != 'S')
                {
                    enemyRow = playerRow;
                    enemyCol = col;
                }
            }
        }

        private void MoveEnemyPosition()
        {
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    if (room[row][col] == 'b')
                    {
                        if (IsInside(row, col + 1))
                        {
                            room[row][col] = '.';
                            room[row][col + 1] = 'b';
                            col++;
                        }
                        else
                        {
                            room[row][col] = 'd';
                        }
                    }
                    else if (room[row][col] == 'd')
                    {
                        if (IsInside(row, col - 1))
                        {
                            room[row][col] = '.';
                            room[row][col - 1] = 'd';
                        }
                        else
                        {
                            room[row][col] = 'b';
                        }
                    }
                }
            }
        }

        private bool IsInside(int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < room.Length
                && targetCol >= 0 && targetCol < room[targetRow].Length;
        }

        private void InitializeField()
        {
            room = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                var values = Console.ReadLine()?.ToCharArray();
                if (values != null)
                {
                    room[row] = new char[values.Length];

                    for (int col = 0; col < values.Length; col++)
                    {
                        room[row][col] = values[col];

                        if (room[row][col] == 'S')
                        {
                            playerRow = row;
                            playerCol = col;
                        }
                    }
                }
            }
        }
    }
}
