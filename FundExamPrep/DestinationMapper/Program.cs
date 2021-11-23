using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"(\/|\=)(?<destination>[A-Z]{1}[A-Za-z]{2,})\1");
            MatchCollection matches = pattern.Matches(input);
            int destinationPoints = 0;

            foreach (Match destination in matches)
            {
                destinationPoints += destination.Groups["destination"].Value.Length;
            }

            List<string> destinations = matches
                .Cast<Match>()
                .Select(x => x.Value.Trim('=' , '/'))
                .ToList();

            Console.Write("Destinations: ");
            Console.WriteLine(string.Join(", " ,destinations));
            Console.WriteLine($"Travel Points: {destinationPoints}");

        }
    }
}
