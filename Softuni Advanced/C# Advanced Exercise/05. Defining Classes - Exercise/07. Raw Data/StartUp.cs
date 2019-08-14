using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftuniParking
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                var Input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = Input[0];

                int engineSpeed = int.Parse(Input[1]);
                int enginePower = int.Parse(Input[2]);
                var engine = new Engine(engineSpeed, enginePower);

                int cargoWeigh = int.Parse(Input[3]);
                string cargoType = Input[4];
                var Cargo = new Cargo(cargoWeigh, cargoType);

                var tires = new List<Tire>();

                for (int j = 5; j < Input.Length; j += 2)
                {
                    double pressure = double.Parse(Input[j]);
                    int age = int.Parse(Input[j + 1]);

                    tires.Add(new Tire(pressure, age));
                }
                cars.Add(new Car(model, engine, Cargo, tires));

            }
            string command = Console.ReadLine();

            if (command == "fragile")
            {
                cars.Where(c => c.Cargo.Type == "fragile" && c.Tire.Any(t => t.Pressure < 1))
                    .Select(c => c.Model)
                    .ToList()
                    .ForEach(Console.WriteLine);
            }
            else if(command == "flamable")
            {
                cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250)
                    .Select(c => c.Model)
                    .ToList()
                    .ForEach(Console.WriteLine);
            }
        }
    }
}
