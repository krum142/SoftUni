using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Engine> engines = new List<Engine>();
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int power = int.Parse(input[1]);

                if (input.Length == 2)
                {
                    engines.Add(new Engine(model, power));
                }
                else if (input.Length == 3)
                {
                    if (input[2].All(char.IsDigit))
                    {
                        int displacement = int.Parse(input[2]);
                        engines.Add(new Engine(model, power, displacement));
                    }
                    else
                    {
                        string efficency = input[2];
                        engines.Add(new Engine(model, power, efficency));
                    }
                }
                else if(input.Length == 4)
                {
                    int displacement = int.Parse(input[2]);
                    string efficiency = input[3];

                    engines.Add(new Engine(model, power, displacement, efficiency));
                }
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = input[0];
                Engine engine = engines.First(e => e.Model == input[1]);

                if(input.Length == 2)
                {
                    cars.Add(new Car(model, engine));
                }
                else if(input.Length == 3)
                {
                    if (input[2].All(char.IsDigit))
                    {
                        int weight = int.Parse(input[2]);
                        cars.Add(new Car(model, engine, weight));
                    }
                    else
                    {
                        string color = input[2];
                        cars.Add(new Car(model, engine, color));
                    }
                }
                else if(input.Length == 4)
                {
                    string color = input[3];
                    int weight = int.Parse(input[2]);

                    cars.Add(new Car(model,engine,color,weight));
                }
            }

           // cars.ForEach(Console.WriteLine);

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model}:");

                Console.WriteLine($"  {car.Engine.Model}:");
                Console.WriteLine($"    Power: {car.Engine.Power}");
                Console.WriteLine($"    Displacement: {(car.Engine.Displacement == null ? "n/a" : car.Engine.Displacement.ToString())}");
                Console.WriteLine($"    Efficiency: {(car.Engine.Efficiency == null ? "n/a" : car.Engine.Efficiency.ToString())}");

                Console.WriteLine($"  Weight: {(car.Weight == null ? "n/a" : car.Weight.ToString())}");
                Console.WriteLine($"  Color: {(car.Color == null ? "n/a" : car.Color)}");

            }
        }
    }
}
