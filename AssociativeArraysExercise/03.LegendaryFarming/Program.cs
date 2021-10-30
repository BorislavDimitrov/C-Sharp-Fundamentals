using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isEnoughMaterial = false;
            var materialsDictionary = new Dictionary<string , int>();
            materialsDictionary.Add("shards" , 0);
            materialsDictionary.Add("motes" , 0);
            materialsDictionary.Add("fragments" , 0);

            while (isEnoughMaterial == false)
            {
                List<string> materials = Console.ReadLine().Split().ToList();
                

                for (int i = 0; i < materials.Count; i += 2)
                {
                    string materialName = materials[i + 1].ToLower();
                    int materialQuanity = int.Parse(materials[i]);

                    if (materialsDictionary.ContainsKey(materialName))
                    {
                        materialsDictionary[materialName] += materialQuanity;
                    }
                    else
                    {
                        materialsDictionary.Add(materialName , materialQuanity);
                    }
                    isEnoughMaterial = CheckIfEnoughMaterials(materialsDictionary);

                    if (isEnoughMaterial)
                    {
                        break;
                    }
                }
                
            }

            materialsDictionary = materialsDictionary.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key , y => y.Value);
            PrintMysticMaterials(materialsDictionary);
            materialsDictionary = materialsDictionary.OrderBy(x => x.Key).ToDictionary(x => x.Key , y => y.Value);
            PrintJunkItems(materialsDictionary);
        }

        public static bool CheckIfEnoughMaterials (Dictionary<string , int> materials)
        {
            bool isEnoughMaterial = false;

            foreach (var material in materials)
            {
                if (material.Value >= 250 && (material.Key == "shards" || material.Key == "motes" || material.Key == "fragments"))
                {
                    isEnoughMaterial = true;

                    if (material.Key == "shards")
                    {
                        Console.WriteLine("Shadowmourne obtained!");
                        materials[material.Key] -= 250;
                    }
                    else if (material.Key == "motes")
                    {
                        Console.WriteLine("Dragonwrath obtained!");
                        materials[material.Key] -= 250;
                    }
                    else if (material.Key == "fragments")
                    {
                        Console.WriteLine("Valanyr obtained!");
                        materials[material.Key] -= 250;
                    }
                    break;
                }
            }
            return isEnoughMaterial;
        }

        public static void PrintMysticMaterials (Dictionary<string , int> materialsDictionary)
        {
            foreach (var material in materialsDictionary)
            {
                if (material.Key == "shards")
                {
                    Console.WriteLine($"{material.Key}: {materialsDictionary[material.Key]}");
                }
                else if (material.Key == "motes")
                {
                    Console.WriteLine($"{material.Key}: {materialsDictionary[material.Key]}");
                }
                else if (material.Key == "fragments")
                {
                    Console.WriteLine($"{material.Key}: {materialsDictionary[material.Key]}");
                }
            }
        }

        public static void PrintJunkItems (Dictionary<string , int> materialsDictionary)
        {
            foreach (var material in materialsDictionary)
            {
                if (material.Key != "shards" && material.Key != "motes" && material.Key != "fragments")
                {
                    Console.WriteLine($"{material.Key}: {materialsDictionary[material.Key]}");
                }
            }
        }
    }
}
