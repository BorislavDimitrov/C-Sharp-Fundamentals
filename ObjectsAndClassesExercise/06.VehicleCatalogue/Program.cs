using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Catalogue vehicleCatalogue = new Catalogue();

            while ((input = Console.ReadLine()) != "End")
            {
                List<string> vehicleInfo = input.Split().ToList();
                string vehicleType = vehicleInfo[0];
                string vehicleModel = vehicleInfo[1];
                string vehicleColor = vehicleInfo[2];
                int vehicleHorsepower = int.Parse(vehicleInfo[3]);

                if (vehicleType == "truck")
                {
                    Truck truck = new Truck(vehicleType , vehicleModel , vehicleColor , vehicleHorsepower);
                    vehicleCatalogue.Trucks.Add(truck);
                }
                else if (vehicleType == "car")
                {
                    Car car = new Car(vehicleType , vehicleModel , vehicleColor , vehicleHorsepower);
                    vehicleCatalogue.Cars.Add(car);
                }
            }

            string vehicleInfos = string.Empty;

            while ((vehicleInfos = Console.ReadLine()) != "Close the Catalogue")
            {
                string vehicleModel = vehicleInfos;

                vehicleCatalogue.PrintVechileByModel(vehicleModel);
            }

            vehicleCatalogue.PrintCarsAverageHorsepower();
            vehicleCatalogue.PrintTrucksAverageHorsepower();
        }
    }
}
