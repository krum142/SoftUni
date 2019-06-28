using System;
using System.Collections.Generic;
using System.Linq;

namespace Auto_Repair_and_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            var CarsModels = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var queueOfCars = new Queue<string>(CarsModels);
            var ServedCars = new Stack<string>();

            var command = Console.ReadLine().Split("-");

            while (command[0] != "End")
            {
                var whatToDo = command[0];

                if (whatToDo == "Service" && queueOfCars.Any())
                {
                    var vehicle = queueOfCars.Peek();
                    ServedCars.Push(queueOfCars.Dequeue());
                    Console.WriteLine($"Vehicle {vehicle} got served.");
                }

                if (whatToDo == "CarInfo")
                {
                    if (queueOfCars.Contains(command[1]))
                    {
                        Console.WriteLine($"Still waiting for service.");
                    }
                    else if (ServedCars.Contains(command[1]))
                    {
                        Console.WriteLine("Served.");
                    }
                }

                if (whatToDo == "History")
                {
                    Console.WriteLine(string.Join(", ", ServedCars));
                }

                command = Console.ReadLine().Split("-");
            }

            if (queueOfCars.Any())
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", queueOfCars)}");
            }

            Console.WriteLine($"Served vehicles: {string.Join(", ", ServedCars)}");
        }
    }
}