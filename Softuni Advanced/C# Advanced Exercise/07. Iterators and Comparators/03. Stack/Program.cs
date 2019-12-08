using System;
using System.Linq;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var stack = new CustomStack<string>();


            while (command[0] != "END")
            {

                if (command[0] == "Push")
                {
                    stack.Push(command.Skip(1).ToList());
                }
                else if (command[0] == "Pop")
                {
                    stack.Pop();
                }

                command = Console.ReadLine()
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            for (int i = 0; i < 2; i++)
            {
                foreach (var item in stack)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
