using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double> plantsRarity = new Dictionary<string, double>();
            Dictionary<string, List<double>> plantsRatings = new Dictionary<string, List<double>>();
            List<Plant> plants = new List<Plant>();

            for (int i = 0; i < n; i++)
            {
                List<string> commandInfo = Console.ReadLine().Split("<->").ToList();
                string plantName = commandInfo[0];
                double plantRarity = double.Parse(commandInfo[1]);

                if (plantsRarity.ContainsKey(plantName))
                {
                    plantsRarity[plantName] = plantRarity;
                }
                else
                {
                    plantsRarity.Add(plantName, plantRarity);
                }

                if (!plantsRatings.ContainsKey(plantName))
                {
                    List<double> ratings = new List<double>();
                    plantsRatings.Add(plantName, ratings);
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Exhibition")
            {
                Regex pattern = new Regex(@"(?<command>[\w]+)\s*:\s*(?<plantName>[\w]+)\s*(\s*-\s*(?<number>[0-9]+))?");
                Match commandInfo;

                commandInfo = pattern.Match(input);

                string firstCommand = commandInfo.Groups["command"].Value.Trim();
                string plantName = commandInfo.Groups["plantName"].Value.Trim();
                double numberCommand = 0;

                if (firstCommand == "Rate")
                {
                    numberCommand = double.Parse(commandInfo.Groups["number"].Value);

                    if (plantsRatings.ContainsKey(plantName))
                    {
                        plantsRatings[plantName].Add(numberCommand);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    
                }
                else if (firstCommand == "Update")
                {
                    numberCommand = double.Parse(commandInfo.Groups["number"].Value);

                    if (plantsRarity.ContainsKey(plantName))
                    {
                        plantsRarity[plantName] = numberCommand;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (firstCommand == "Reset")
                {

                    if (plantsRatings.ContainsKey(plantName))
                    {
                        plantsRatings[plantName].Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
            }

            foreach (var plant in plantsRatings)
            {
                string plantName = plant.Key;
                double averagePlantRating = 0;

                if (plantsRatings[plantName].Count > 0)
                {
                    averagePlantRating = plantsRatings[plantName].Average();
                }

                double plantRarity = plantsRarity[plantName];
                Plant newPlant = new Plant(plantName , plantRarity , averagePlantRating);

                plants.Add(newPlant);
            }

            plants = plants.OrderByDescending(x => x.Rarity).ThenByDescending(x => x.AverageRating).ToList();
            Console.WriteLine("Plants for the exhibition:");

            for (int i = 0; i < plants.Count; i++)
            {
                Console.WriteLine($"- {plants[i].Name}; Rarity: {plants[i].Rarity}; Rating: {plants[i].AverageRating:F2}");
            }
        }
    }
}
