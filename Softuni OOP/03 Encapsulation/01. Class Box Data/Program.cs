using System;
using ClassBoxData.Models;

namespace ClassBoxData
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                double length = double.Parse(Console.ReadLine());
                double weigth = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());

                Box box = new Box(length, weigth, height);

                Console.WriteLine(box.ToString());
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
                
            }
        }
    }
}
