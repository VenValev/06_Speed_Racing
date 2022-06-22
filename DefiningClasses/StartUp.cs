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

            for(int i = 0; i < n; i++)
            {
                string[] text = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = text[0];
                decimal fuelAmount = decimal.Parse(text[1]);
                decimal fuelConsumptionPerKilometer = decimal.Parse(text[2]);
                Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
                cars.Add(car);
            }

            string cmnd;

            while((cmnd = Console.ReadLine()) != "End")
            {
                string model = cmnd.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1];
                decimal amountOfKM = decimal.Parse(cmnd.Split(' ', StringSplitOptions.RemoveEmptyEntries)[2]);
                Car carToDrive = cars.First(c => c.Model == model);
                carToDrive.Drive(amountOfKM);
            }

            foreach(Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}
