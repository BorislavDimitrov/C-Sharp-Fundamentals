using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
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
                int engineSpeed = int.Parse(carInfo[1]);
                int enginePower = int.Parse(carInfo[2]);
                int cargoWeight = int.Parse(carInfo[3]);
                string cargoType = carInfo[4];
                Engine currentCarEngine = new Engine(engineSpeed , enginePower);
                Cargo currentCarCargo = new Cargo(cargoWeight , cargoType);
                Car currentCar = new Car(carModel , currentCarEngine , currentCarCargo);
                cars.Add(currentCar);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                PrintFragileCargos(cars);
            }
            else if (command =="flamable")
            {
                PrintFlamableCargos(cars);
            }
        }

        public static void PrintFragileCargos (List<Car> cars)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Cargo.Type == "fragile" && cars[i].Cargo.Weight < 1000)
                {
                    Console.WriteLine(cars[i].Model);
                }
            }
        }

        public static void PrintFlamableCargos (List<Car> cars)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].Cargo.Type == "flamable" && cars[i].Engine.Power > 250)
                {
                    Console.WriteLine(cars[i].Model);
                }
            }
        }
    }
}
