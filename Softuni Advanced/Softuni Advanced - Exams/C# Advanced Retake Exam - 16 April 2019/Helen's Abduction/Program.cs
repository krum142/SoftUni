using System;
using System.Linq;

namespace Helen_s_Abduction
{
    class Program
    {

        static int PRow;
        static int PCol;
        static int OldPRow;
        static int OldPCol;
        static void Main(string[] args)
        {
            

            int energy = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());

            char[][] field = new char[lines][];
            addInputInArray(lines, field);

            FindP(field);
            bool winDie = false;
            while (true)
            {
                var command = Console.ReadLine().Split();

                var direction = command[0];
                var SpartanSpawnRow = int.Parse(command[1]);
                var SpartanSpawnCol = int.Parse(command[2]);

                field[SpartanSpawnRow][SpartanSpawnCol] = 'S';

                field[PRow][PCol] = '-';

                OldPRow = PRow;
                OldPCol = PCol;

                MoveP(field,direction);

                if (field[PRow][ PCol] == 'S')
                {
                    energy -= 2;
                    field[PRow][ PCol] = 'P';
                }
                else if(field[PRow][ PCol] == 'H')
                {
                    field[PRow][ PCol] = '-';
                    winDie = true;
                    break;
                }
                else if(field[PRow][ PCol] == '-')
                {
                    field[PRow][ PCol] = 'P';
                }
                
                energy--;
                if (energy <= 0)
                {
                    field[PRow][PCol] = 'X';
                    break;
                }

            }
            if (winDie)
            {
                Console.WriteLine($"Paris has successfully abducted Helen! Energy left: {energy - 1}");
            }
            else
            {
                Console.WriteLine($"Paris died at {PRow};{PCol}.");
            }
            Test(field);

        }

        private static void MoveP(char[][] field,string direction)
        {
            if (direction == "up")
            {
                if (PRow - 1 >= 0)
                {
                    PRow--;
                }
            }
            else if (direction == "down")
            {
                if (PRow + 1 < field.Length)
                {
                    PRow++;
                }
            }
            else if (direction == "left")
            {
                if (PCol - 1 >= 0)
                {
                    PCol--;
                }
            }
            else if (direction == "right")
            {
                if (PCol + 1 < field[PRow].Length)
                {
                    PCol++;
                }
            }
        }

        private static void Test(char[][] field)
        {

            foreach (var item in field)
            {
                Console.WriteLine(string.Join("", item));
            }
        }
        private static void FindP(char[][] field)
        {
            for (int i = 0; i < field.Length; i++)
            {
                for (int j = 0; j < field[i].Length; j++)
                {
                    if (field[i][j] == 'P')
                    {
                        PRow = i;
                        PCol = j;
                    }
                }
            }
        }

        private static void addInputInArray(int Lines, char[][] Field)
        {
            for (int i = 0; i < Lines; i++)
            {
                var x = Console.ReadLine().ToCharArray();

                    Field[i] = x;
            }
        }
    }
}