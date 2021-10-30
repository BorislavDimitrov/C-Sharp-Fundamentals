using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dragon> listOfDragons = new List<Dragon>();
            int inputLines = int.Parse(Console.ReadLine());
            var dragons = new Dictionary<string, SortedDictionary<string, List<string>>>();

            for (int i = 0; i < inputLines; i++)
            {
                List<string> dragonInfo = Console.ReadLine().Split().ToList();
                string dragonType = dragonInfo[0];
                string dragonName = dragonInfo[1];
                string dragonStats = $"{dragonInfo[2]},{dragonInfo[3]},{dragonInfo[4]}";

                if (dragons.ContainsKey(dragonType))
                {
                    if (dragons[dragonType].ContainsKey(dragonName))
                    {
                        dragons[dragonType][dragonName].Clear();
                        dragons[dragonType][dragonName].Add(dragonStats);
                    }
                    else
                    {                       
                        List<string> currentDragonStats = new List<string>();
                        currentDragonStats.Add(dragonStats);
                        dragons[dragonType].Add(dragonName , currentDragonStats);
                    }
                }
                else
                {
                    SortedDictionary<string, List<string>> currentDragonName = new SortedDictionary<string, List<string>>();
                    List<string> currentDragonStats = new List<string>();
                    currentDragonStats.Add(dragonStats);
                    currentDragonName.Add(dragonName , currentDragonStats);
                    dragons.Add(dragonType ,currentDragonName );
                }
            }

            var types = new Dictionary<string, string>();
            MakeListOfDragons(dragons , listOfDragons);
            MakeDictionaryWithAverageStatsForTypes(listOfDragons , types);
            PrintDragons(dragons , types);
        }

        public static void MakeListOfDragons (Dictionary<string , SortedDictionary<string , List<string>>> dragons , List<Dragon> listOfDragons)
        {
            foreach (var type in dragons)
            {
                foreach (var name in dragons[type.Key])
                {
                    List<string> currentDragonStats = new List<string>();
                    currentDragonStats = name.Value[0].Split(',' , StringSplitOptions.RemoveEmptyEntries).ToList();
                    double dragonDamage = 0;
                    double dragonHealth = 0;
                    double dragonArmor = 0;

                    if (currentDragonStats[0] == "null")
                    {
                        dragonDamage = 45;
                    }
                    else
                    {
                        dragonDamage = int.Parse(currentDragonStats[0]);
                    }

                    if (currentDragonStats[1] == "null")
                    {
                        dragonHealth = 250;
                    }
                    else
                    {
                        dragonHealth = int.Parse(currentDragonStats[1]);
                    }

                    if (currentDragonStats[2] == "null")
                    {
                        dragonArmor = 10;
                    }
                    else
                    {
                        dragonArmor = int.Parse(currentDragonStats[2]);
                    }

                    Dragon currentDragon = new Dragon(type.Key , name.Key , dragonDamage , dragonHealth , dragonArmor);
                    listOfDragons.Add(currentDragon);
                }
            }
        }

        public static void MakeDictionaryWithAverageStatsForTypes (List<Dragon> listOfDragons , Dictionary<string , string> types)
        {
            for (int i = 0; i < listOfDragons.Count; i++)
            {
                string currentType = listOfDragons[i].Type;
                double averageDamage = 0;
                double totalDamage = 0;
                double averageHealth = 0;
                double totalHealth = 0;
                double averageArmor = 0;
                double totalArmor = 0;
                double dragonsCount = 0;

                for (int j = 0; j < listOfDragons.Count; j++)
                {
                    if (listOfDragons[j].Type == currentType)
                    {
                        totalDamage += listOfDragons[j].Damage;
                        totalHealth += listOfDragons[j].Health;
                        totalArmor += listOfDragons[j].Armor;
                        dragonsCount++;
                    }
                }

                averageDamage = totalDamage / dragonsCount;
                averageHealth = totalHealth / dragonsCount;
                averageArmor = totalArmor / dragonsCount;

                string averageStats = $"{averageDamage},{averageHealth},{averageArmor}";

                if (!types.ContainsKey(listOfDragons[i].Type))
                {
                    types.Add(currentType , averageStats);
                }
            }
        }

        public static void PrintDragons (Dictionary<string , SortedDictionary<string , List<string>>> dragons , Dictionary<string , string> types)
        {
            foreach (var type in dragons)
            {
                foreach (var name in types)
                {
                    if (type.Key == name.Key)
                    {
                        List<string> dragonInfo = name.Value.Split(',' , StringSplitOptions.RemoveEmptyEntries).ToList();
                       double dragonDamage = double.Parse(dragonInfo[0]);
                       double dragonHealth = double.Parse(dragonInfo[1]);
                       double dragonArmor = double.Parse(dragonInfo[2]);

                        Console.WriteLine($"{name.Key}::({dragonDamage:F2}/{dragonHealth:F2}/{dragonArmor:F2})");
                    }
                }

                foreach (var name in dragons[type.Key])
                {
                    List<string> currentDragonStats = name.Value[0].Split(',').ToList();
                    double dragonDamage = 0;
                    double dragonHealth = 0;
                    double dragonArmor = 0;

                    if (currentDragonStats[0] == "null")
                    {
                        dragonDamage = 45;
                    }
                    else
                    {
                        dragonDamage = int.Parse(currentDragonStats[0]);
                    }

                    if (currentDragonStats[1] == "null")
                    {
                        dragonHealth = 250;
                    }
                    else
                    {
                        dragonHealth = int.Parse(currentDragonStats[1]);
                    }

                    if (currentDragonStats[2] == "null")
                    {
                        dragonArmor = 10;
                    }
                    else
                    {
                        dragonArmor = int.Parse(currentDragonStats[2]);
                    }

                    Console.WriteLine($"-{name.Key} -> damage: {dragonDamage}, health: {dragonHealth}, armor: {dragonArmor}");
                }
            }
        }
    }
}
