using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var date1 = Console.ReadLine();
            var date2 = Console.ReadLine();

            DateModifier x = new DateModifier(date1, date2);

            Console.WriteLine(x.Difference());

        }
    }
}
