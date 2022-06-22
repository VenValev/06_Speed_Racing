using System;
using System.Collections.Generic;

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
                double fuelAmount = double.Parse(text[1]);
                double fuelConsumptionPerKilometer = double.Parse(text[2]);
                Car car = new Car(model, fuelAmount, fuelConsumptionPerKilometer);
                cars.Add(car);
            }

            string cmnd;

            while((cmnd = Console.ReadLine()) != "end")
            {
                string model = cmnd.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1];
                double amountOfKM = double.Parse(cmnd.Split(' ', StringSplitOptions.RemoveEmptyEntries)[1]);
            }
        }
    }
}
