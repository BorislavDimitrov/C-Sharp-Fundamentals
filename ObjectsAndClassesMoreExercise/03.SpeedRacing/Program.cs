using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                List<string> carInfo = Console.ReadLine().Split().ToList();
                string carModel = carInfo[0];
                double fuelAmount = double.Parse(carInfo[1]);
                double fuelConsum = double.Parse(carInfo[2]);
                Car currentCar = new Car(carModel , fuelAmount , fuelConsum);
                cars.Add(currentCar);
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                List<string> command = input.Split().ToList();
                string carModel = command[1];
                double kmToTravel = double.Parse(command[2]);
                Car carToMove = new Car();

                for (int i = 0; i < cars.Count; i++)
                {
                    if (cars[i].Model == carModel)
                    {
                        carToMove.Model = carModel;
                        carToMove.FuelAmount = cars[i].FuelAmount;
                        carToMove.FuelConsumPerKm = cars[i].FuelConsumPerKm;
                    }
                }

                if (carToMove.CheckIfFuelEnough(kmToTravel))
                {
                    for (int i = 0; i < cars.Count; i++)
                    {
                        if (cars[i].Model == carModel)
                        {
                            cars[i].DistanceTraveled += kmToTravel;
                            cars[i].FuelAmount -= (kmToTravel * cars[i].FuelConsumPerKm);
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }
            PrintCars(cars);
        }

        public static void PrintCars(List<Car> cars)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{cars[i].Model} {cars[i].FuelAmount:F2} {cars[i].DistanceTraveled}");
            }
        }
    }
}
