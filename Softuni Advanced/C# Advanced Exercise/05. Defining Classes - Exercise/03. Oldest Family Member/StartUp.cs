using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int familyMCount = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < familyMCount; i++)
            {
                string[] memberData = Console.ReadLine().Split();

                string memberName = memberData[0];
                int memberAge = int.Parse(memberData[1]);

                Person member = new Person(memberName, memberAge);

                family.AddMember(member);
            }

            Person oldeest = family.GetOldestMember();

            Console.WriteLine($"{oldeest.Name} {oldeest.Age}");
        }
    }
}
