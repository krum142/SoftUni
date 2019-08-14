using System;

namespace GenericCountMethodString
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var box = new Box<string>();
            for (int i = 0; i < n; i++)
            {
                box.Add(Console.ReadLine());
            }
            string stringToCompare = Console.ReadLine();

            box.Compare(stringToCompare);
            //var changeValues = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //box.Swap(changeValues[0], changeValues[1]);
            Console.WriteLine(box.CountGrater);
        }
    }
}
