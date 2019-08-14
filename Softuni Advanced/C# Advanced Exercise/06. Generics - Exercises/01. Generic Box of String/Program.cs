using System;
using System.Linq;
namespace Test01
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var box = new Box<string>(); 
            for (int i = 0; i < n; i++)
            {
                box.Add(Console.ReadLine());
            }
            Console.WriteLine(box);
        }
    }
}
