using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public Car(string model, double fuelAmount, double FuelConsumptionPerKilometer)
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0;
        }

        private string Model
        {
            get; set;
        }
        public double FuelAmount
        {
            get; set;
        }
        public double FuelConsumptionPerKilometer
        {
            get; set;
        }

        public double TravelledDistance {get; set; }

        public void Drive(double amountOfKM)
        {
            double neededLiters = amountOfKM * FuelConsumptionPerKilometer;
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
