using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.VehileCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            VehilesCatalogue catalogue = new VehilesCatalogue();

            while ((input = Console.ReadLine()) != "end")
            {
                List<string> vehileInfos = input.Split("/").ToList();
                string type = vehileInfos[0];
                string brand = vehileInfos[1];
                string model = vehileInfos[2];
                int weightOrHorsepower = int.Parse(vehileInfos[3]);

                Car car = new Car();
                Truck truck = new Truck();

                if (type == "Car")
                {
                    car.Brand = brand;
                    car.Model = model;
                    car.Horsepower = weightOrHorsepower;
                    catalogue.Cars.Add(car);
                }
                else if (type == "Truck")
                {
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = weightOrHorsepower;
                    catalogue.Trucks.Add(truck);
                }
            }

            List<Car> cars = catalogue.Cars;
            cars = cars.OrderBy(car => car.Brand).ToList();

            List<Truck> trucks = catalogue.Trucks;
            trucks = trucks.OrderBy(truck => truck.Brand).ToList();

            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                for (int i = 0; i < cars.Count; i++)
                {
                    PrintOneCarElement(cars[i]);
                }
            }
            

            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                for (int j = 0; j < trucks.Count; j++)
                {
                    PrintOneTruckElement(trucks[j]);
                }
            }
           
        }

        public static void PrintOneCarElement(Car car)
        {
            Console.WriteLine($"{car.Brand}: {car.Model} - {car.Horsepower}hp");
        }

        public static void PrintOneTruckElement(Truck truck)
        {
            Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
        }
    }

    
}
