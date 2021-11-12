using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> participatians = Console.ReadLine().Split(", ").ToList();
            Dictionary<string, int> racers = new Dictionary<string, int>();

            for (int i = 0; i < participatians.Count; i++)
            {
                racers.Add(participatians[i] , 0);
            }

            string input = string.Empty;
            Regex lettersPatter = new Regex(@"[A-Za-z]");
            Regex numbersPattern = new Regex(@"[0-9]");

            while ((input = Console.ReadLine()) != "end of race")
            {
                var nameLetters = lettersPatter.Matches(input);
                var numbers = numbersPattern.Matches(input);
                string name = string.Empty;
                int kms = 0;

                foreach (Match match in numbers)
                {
                    kms += int.Parse(match.Value);
                }

                foreach (Match match in nameLetters)
                {
                    name += $"{match.Value}";
                }

                if (racers.ContainsKey(name))
                {
                    racers[name] += kms;
                }
            }

            racers = racers.OrderByDescending(x => x.Value).ToDictionary(x => x.Key , y => y.Value);
            int counter = 0;

            foreach (var racer in racers)
            {
                counter++;

                if (counter > 3)
                {
                    break;
                }

                if (counter == 1)
                {
                    Console.WriteLine($"1st place: {racer.Key}");
                }
                else if (counter == 2)
                {
                    Console.WriteLine($"2nd place: {racer.Key}");
                }
                else if (counter == 3)
                {
                    Console.WriteLine($"3rd place: {racer.Key}");
                }
            }
        }  
    }
}
