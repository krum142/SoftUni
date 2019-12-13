using Ferraries.Models;
using System;

namespace Ferraries
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            Ferrari ferrari = new Ferrari(name);

            Console.WriteLine(ferrari);
        }
    }
}
