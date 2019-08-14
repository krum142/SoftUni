using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Car
    {
        public Car (string model,double fuelAmount ,double fuelConPerKilo)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConPerKilo = fuelConPerKilo;

            TravelledDistance = 0;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConPerKilo { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(double amountOfKm)
        {
            double requiredFuel = amountOfKm * FuelConPerKilo;
            if(requiredFuel <= FuelAmount)
            {
                TravelledDistance += amountOfKm;
                FuelAmount -= requiredFuel;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

        }
    }
}
