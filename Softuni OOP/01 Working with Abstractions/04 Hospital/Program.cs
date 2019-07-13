using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class Program
    {
        public static void Main()
        {
            Dictionary<string, List<string>> Doctors = new Dictionary<string, List<string>>();
            Dictionary<string, List<List<string>>> department = new Dictionary<string, List<List<string>>>();

            string command = Console.ReadLine();

            while (command != "Output")
            {
                string[] tokens = command.Split();
                var departament = tokens[0];
                var firstName = tokens[1];
                var secondName = tokens[2];
                var patient = tokens[3];
                var fullName = firstName + secondName;

                if (!Doctors.ContainsKey(firstName + secondName))
                {
                    Doctors[fullName] = new List<string>();
                }

                if (!department.ContainsKey(departament))
                {
                    department[departament] = new List<List<string>>();
                    for (int stai = 0; stai < 20; stai++)
                    {
                        department[departament].Add(new List<string>());
                    }
                }

                bool isThereSpace = department[departament]
                    .SelectMany(x => x)
                    .Count() < 60;

                if (isThereSpace)
                {
                    int room = 0;
                    Doctors[fullName].Add(patient);
                    for (int currentRoom = 0; currentRoom < department[departament].Count; currentRoom++)
                    {
                        if (department[departament][currentRoom].Count < 3)
                        {
                            room = currentRoom;
                            break;
                        }
                    }
                    department[departament][room].Add(patient);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] args = command.Split();
                PrintOutput(Doctors, department, args);
                command = Console.ReadLine();
            }
        }

        private static void PrintOutput(Dictionary<string, List<string>> Doctors, Dictionary<string, List<List<string>>> department, string[] args)
        {
            if (args.Length == 1)
            {
                Console.WriteLine(string.Join("\n", department[args[0]].Where(x => x.Count > 0).SelectMany(x => x)));
            }
            else if (args.Length == 2 && int.TryParse(args[1], out int staq))
            {
                Console.WriteLine(string.Join("\n", department[args[0]][staq - 1].OrderBy(x => x)));
            }
            else
            {
                Console.WriteLine(string.Join("\n", Doctors[args[0] + args[1]].OrderBy(x => x)));
            }
        }
    }
}
