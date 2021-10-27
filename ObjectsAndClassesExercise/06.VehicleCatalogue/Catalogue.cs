using System;
using System.Collections.Generic;
using System.Text;

namespace _06.VehicleCatalogue
{
    class Catalogue
    {
        public List<Car> Cars { get; set; } = new List<Car>();
        public List<Truck> Trucks { get; set; } = new List<Truck>();

        public  void PrintVechileByModel(string model)
        {
                for (int i = 0; i < Cars.Count; i++)
                {
                    if (Cars[i].Model == model )
                    {
                        Console.WriteLine($"Type: Car");
                        Console.WriteLine($"Model: {Cars[i].Model}");
                        Console.WriteLine($"Color: {Cars[i].Color}");
                        Console.WriteLine($"Horsepower: {Cars[i].Horsepower}");
                        break;
                    }
                }
            
            
                for (int i = 0; i < Trucks.Count; i++)
                {
                    if (Trucks[i].Model == model)
                    {
                        Console.WriteLine($"Type: Truck");
                        Console.WriteLine($"Model: {Trucks[i].Model}");
                        Console.WriteLine($"Color: {Trucks[i].Color}");
                        Console.WriteLine($"Horsepower: {Trucks[i].Horsepower}");
                        break;
                    }
                }
        }

        public void PrintCarsAverageHorsepower ()
        {
            double horsepower = 0;
            double carsCount = 0;

            for (int i = 0; i < Cars.Count; i++)
            {
                horsepower += Cars[i].Horsepower;
                carsCount = Cars.Count;
            }

            double averageHorsepower = 0;
            averageHorsepower = horsepower / carsCount;

            if (carsCount == 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {0}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {averageHorsepower:F2}.");
            }
        }

        public void PrintTrucksAverageHorsepower()
        {
            double horsepower = 0;
            double trucksCount = 0;

            for (int i = 0; i < Trucks.Count; i++)
            {
                horsepower += Trucks[i].Horsepower;
                trucksCount = Trucks.Count;
            }

            double averageHorsepower = 0;
            averageHorsepower = horsepower / trucksCount;

            if (trucksCount == 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {0}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {averageHorsepower:F2}.");
            }
            
        }
    }

}
