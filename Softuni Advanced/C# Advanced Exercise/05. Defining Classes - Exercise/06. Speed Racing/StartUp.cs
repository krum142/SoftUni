using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var carData = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string carModel = carData[0];
                double fuelAmount = double.Parse(carData[1]);
                double fuelConsuPerKm = double.Parse(carData[2]);

                Car car = new Car(carModel, fuelAmount, fuelConsuPerKm);
                cars.Add(car);
            }

            while (true)
            {
                string inputLine = Console.ReadLine();

                if(inputLine == "End")
                {
                    break;
                }

                var data = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string carModel = data[1];
                double distance = double.Parse(data[2]);

                Car car = cars.FirstOrDefault(c => c.Model == carModel);
                car.Drive(distance);
            }

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
