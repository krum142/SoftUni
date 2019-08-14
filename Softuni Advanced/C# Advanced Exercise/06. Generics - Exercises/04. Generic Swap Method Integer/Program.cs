using System;
using System.Linq;
namespace Test01
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var box = new Box<int>(); 
            for (int i = 0; i < n; i++)
            {
                box.Add(int.Parse(Console.ReadLine()));
            }
            var changeValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            box.Swap(changeValues[0], changeValues[1]);
            Console.WriteLine(box);
        }
    }
}
