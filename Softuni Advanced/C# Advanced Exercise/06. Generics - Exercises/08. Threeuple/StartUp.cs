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
            string City = string.Empty;
            if(Names.Length > 4)
            {
                City = Names[3] + " " + Names[4];
            }
            else
            {
                City = Names[3];
            }

            string Name2 = NameAndLeters[0];
            int LetersBeer = int.Parse(NameAndLeters[1]);
            bool drunkOrNot = NameAndLeters[2] == "drunk" ? true : false ;

            string numberInts = IntDoubles[0];
            double numberDoubles = double.Parse(IntDoubles[1]);
            string BankName = IntDoubles[2];

            var TupNames = new Tuplee<string, string,string>(Name,Adress,City);
            var TupNameBeer = new Tuplee<string, int,bool>(Name2,LetersBeer,drunkOrNot);
            var TupIntDoubles = new Tuplee<string, double, string>(numberInts, numberDoubles, BankName) ;

            Console.WriteLine(TupNames.GetInfo());
            Console.WriteLine(TupNameBeer.GetInfo());
            Console.WriteLine(TupIntDoubles.GetInfo());

        }
    }
}
