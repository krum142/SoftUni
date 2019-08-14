using System;
using System.Linq;
namespace GenericCountMethodString
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var Names = Console.ReadLine()
                .Split();

            var NameAndLeters = Console.ReadLine()
                .Split();

            var IntDoubles = Console.ReadLine()
                .Split();

            string Name = Names[0] + " " + Names[1];
            string Adress = Names[2];

            string Name2 = NameAndLeters[0];
            int LetersBeer = int.Parse(NameAndLeters[1]);

            int numberInts = int.Parse(IntDoubles[0]);
            double numberDoubles = double.Parse(IntDoubles[1]);

            var TupNames = new Tuplee<string, string>(Name,Adress);
            var TupNameBeer = new Tuplee<string, int>(Name2,LetersBeer);
            var TupIntDoubles = new Tuplee<int, double>(numberInts,numberDoubles);

            Console.WriteLine(TupNames.GetInfo());
            Console.WriteLine(TupNameBeer.GetInfo());
            Console.WriteLine(TupIntDoubles.GetInfo());

        }
    }
}
