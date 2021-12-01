using System;
using System.Collections.Generic;
using System.Linq;

namespace _15.Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = string.Empty;
            Dictionary<string, List<double>> cityPopulationAndGoldDic = new Dictionary<string, List<double>>();
            List<City> cities = new List<City>();

            while ((input1 = Console.ReadLine()) != "Sail")
            {
                List<string> cityInfo = input1.Split("||").ToList();
                string cityName = cityInfo[0];
                double cityPopulation = double.Parse(cityInfo[1]);
                double cityGold = double.Parse(cityInfo[2]);

                if (cityPopulationAndGoldDic.ContainsKey(cityName))
                {
                    cityPopulationAndGoldDic[cityName][0] += cityPopulation;
                    cityPopulationAndGoldDic[cityName][1] += cityGold;
                }
                else
                {
                    List<double> populationAndGold = new List<double>();
                    populationAndGold.Add(cityPopulation);
                    populationAndGold.Add(cityGold);
                    cityPopulationAndGoldDic.Add(cityName, populationAndGold);
                }
            }

            string input2 = string.Empty;

            while ((input2 = Console.ReadLine()) != "End")
            {
                List<string> commandInfo = input2.Split("=>").ToList();
                string firstCommand = commandInfo[0];
                string cityName = commandInfo[1];
                double cityPopulation = 0;
                double cityGold = 0;

                if (firstCommand == "Plunder")
                {
                    cityPopulation = double.Parse(commandInfo[2]);
                    cityGold = double.Parse(commandInfo[3]);

                    cityPopulationAndGoldDic[cityName][0] -= cityPopulation;
                    cityPopulationAndGoldDic[cityName][1] -= cityGold;
                    Console.WriteLine($"{cityName} plundered! {cityGold} gold stolen, {cityPopulation} citizens killed.");

                    if (cityPopulationAndGoldDic[cityName][0] == 0 || cityPopulationAndGoldDic[cityName][1] == 0)
                    {
                        cityPopulationAndGoldDic.Remove(cityName);
                        Console.WriteLine($"{cityName} has been wiped off the map!");
                    }
                }
                else if (firstCommand == "Prosper")
                {
                    cityGold = double.Parse(commandInfo[2]);

                    if (cityGold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else
                    {
                        cityPopulationAndGoldDic[cityName][1] += cityGold;
                        Console.WriteLine($"{cityGold} gold added to the city treasury. {cityName} now has {cityPopulationAndGoldDic[cityName][1]} gold.");
                    }
                }
            }

            foreach (var city in cityPopulationAndGoldDic)
            {
                City newCity = new City(city.Key , city.Value[0] , city.Value[1]);
                cities.Add(newCity);
            }

            if (cities.Count > 0)
            {
                cities = cities.OrderByDescending(x => x.Gold).ThenBy(x => x.Name).ToList();
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");

                for (int i = 0; i < cities.Count; i++)
                {
                    Console.WriteLine($"{cities[i].Name} -> Population: {cities[i].Population} citizens, Gold: {cities[i].Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
