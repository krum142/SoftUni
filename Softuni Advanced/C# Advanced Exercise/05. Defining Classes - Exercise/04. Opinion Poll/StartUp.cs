using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int familyMCount = int.Parse(Console.ReadLine());

            Family family = new Family();
            var person = new List<Person>();
            for (int i = 0; i < familyMCount; i++)
            {
                string[] memberData = Console.ReadLine().Split();

                string memberName = memberData[0];
                int memberAge = int.Parse(memberData[1]);

                Person member = new Person(memberName, memberAge);

                person.Add(new Person(memberName, memberAge));
            }

            var reasult = person.Where(x => x.Age > 30).OrderBy(x => x.Name);

            foreach (var x in reasult)
            {
                Console.WriteLine($"{x.Name} - {x.Age}");
            }
            
        }
    }
}
