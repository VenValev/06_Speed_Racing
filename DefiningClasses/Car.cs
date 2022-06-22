using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Car
    {
        private string model;
        private decimal fuelAmount;
        private decimal fuelConsumptionPerKilometer;
        private decimal travelledDistance;

        public Car(string model, decimal fuelAmount, decimal fuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }

        public string Model
        {
            get; set;
        }
        public decimal FuelAmount
        {
            get; set;
        }
        public decimal FuelConsumptionPerKilometer
        {
            get; set;
        }

        public decimal TravelledDistance {get; set; }

        public void Drive(decimal amountOfKM)
        {
            decimal neededLiters = amountOfKM * FuelConsumptionPerKilometer;
            if (FuelAmount >= neededLiters)
            {
                FuelAmount -= neededLiters;
                TravelledDistance += amountOfKM;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

    }
}
