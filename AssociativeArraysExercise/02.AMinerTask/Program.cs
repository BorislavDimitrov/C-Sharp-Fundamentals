using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            var resources = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "stop")
            {
                string resource = input;
                int quanity = int.Parse(Console.ReadLine());

                
                    if (resources.ContainsKey(resource))
                    {
                        resources[resource] += quanity;
                    }
                    else
                    {
                        resources.Add(resource , quanity);
                    }
                
            }
            foreach (var resourcee in resources)
            {
                Console.WriteLine(resourcee.Key + " -> " + resourcee.Value);
            }
        }
    }
}
