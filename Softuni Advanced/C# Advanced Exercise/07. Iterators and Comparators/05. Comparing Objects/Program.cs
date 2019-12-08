using System;
using System.Collections.Generic;

namespace CompareObjects
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split();

                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];

                var person = new Person(name, age, town);
                people.Add(person);

                input = Console.ReadLine();
            }

            int targetPersonIndex = int.Parse(Console.ReadLine());

            int countOfMatches = 1;
            int countOfNotEqualPeaoples = 0;

            Person targetPerson = people[targetPersonIndex - 1];

            foreach (var person in people)
            {
                if(person == targetPerson)
                {
                    continue;
                }

                if (person.CompareTo(targetPerson) == 0)
                {
                    countOfMatches++;
                }
                else
                {
                    countOfNotEqualPeaoples++;
                }
            }

            if (countOfMatches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countOfMatches} {countOfNotEqualPeaoples} {people.Count}");
            }
        }
    }
}
