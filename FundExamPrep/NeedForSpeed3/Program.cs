using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.NeedForSpeed3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            Dictionary<string, List<double>> carMileageFuelDict = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                List<string> info = Console.ReadLine().Split("|").ToList();
                string carName = info[0];
                double carMileage = double.Parse(info[1]);
                double carFuel = double.Parse(info[2]);

                List<double> mileageAndFuel = new List<double>();
                mileageAndFuel.Add(carMileage);
                mileageAndFuel.Add(carFuel);
                carMileageFuelDict.Add(carName , mileageAndFuel);
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Stop")
            {
                List<string> commandInfo = input.Split(" : " , StringSplitOptions.RemoveEmptyEntries).ToList();
                string firstCommand = commandInfo[0];
                string carName = commandInfo[1];
                double distance = 0;
                double fuel = 0;
                double kilometersToBack = 0;

                if (firstCommand == "Drive")
                {
                    distance = double.Parse(commandInfo[2]);
                    fuel = double.Parse(commandInfo[3]);

                    if (carMileageFuelDict[carName][1] >= fuel)
                    {
                        carMileageFuelDict[carName][0] += distance;
                        carMileageFuelDict[carName][1] -= fuel;

                        Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

                        if (carMileageFuelDict[carName][0] >= 100000)
                        {
                            carMileageFuelDict.Remove(carName);
                            Console.WriteLine($"Time to sell the {carName}!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }   
                }
                else if (firstCommand == "Refuel")
                {
                    fuel = double.Parse(commandInfo[2]);

                    if (carMileageFuelDict[carName][1] + fuel >= 75)
                    {
                        double refueledLiters = 75 - carMileageFuelDict[carName][1];
                        carMileageFuelDict[carName][1] = 75;
                        Console.WriteLine($"{carName} refueled with {refueledLiters} liters");

                    }
                    else
                    {
                        carMileageFuelDict[carName][1] += fuel;
                        Console.WriteLine($"{carName} refueled with {fuel} liters");
                    }  
                }
                else if (firstCommand == "Revert")
                {
                    kilometersToBack = double.Parse(commandInfo[2]);

                    if (carMileageFuelDict[carName][0] - kilometersToBack <= 10000)
                    {
                        carMileageFuelDict[carName][0] = 10000;
                    }
                    else
                    {
                        carMileageFuelDict[carName][0] -= kilometersToBack;
                        Console.WriteLine($"{carName} mileage decreased by {kilometersToBack} kilometers");
                    }
                }
            }

            foreach (var car in carMileageFuelDict)
            {
                Car newCar = new Car(car.Key , car.Value[0] , car.Value[1]);
                cars.Add(newCar);
            }

            cars = cars.OrderByDescending(x => x.Mileage).ThenBy(x => x.Name).ToList();

            for (int i = 0; i < cars.Count; i++)
            {
                Console.WriteLine($"{cars[i].Name} -> Mileage: {cars[i].Mileage} kms, Fuel in the tank: {cars[i].Fuel} lt.");
            }
        }
    }
}
