using System;
using System.Collections.Generic;
using System.Linq;
namespace ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {

            string command = Console.ReadLine();

            ListyIterator<string> listyiterator = null;

            while (command != "END")
            {
                try
                {
                    if (command.Contains("Create"))
                    {
                        List<string> items = command.Split().Skip(1).ToList();
                        listyiterator = new ListyIterator<string>(items);

                    }
                    if(command == "HasNext")
                    {
                        Console.WriteLine(listyiterator.HasNext());
                    }
                    if (command == "Move")
                    {
                        Console.WriteLine(listyiterator.Move());
                    }
                    if (command == "Print")
                    {
                        listyiterator.Print();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
                command = Console.ReadLine();
            }

        
            
        }
    }
}
