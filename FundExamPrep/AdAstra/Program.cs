using System;
using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"(\||\#)(?<itemName>[A-Za-z\s]+)\1(?<expireDate>[0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(?<calories>[0-9]+)\1");
            MatchCollection matches = pattern.Matches(input);
            int totalCalories = 0;

            foreach (Match item in matches)
            {
                totalCalories += int.Parse(item.Groups["calories"].Value);
            }

            int daysToSurvive = totalCalories / 2000;

            Console.WriteLine($"You have food to last you for: {daysToSurvive} days!");

            foreach (Match item in matches)
            {
                Console.WriteLine($"Item: {item.Groups["itemName"].Value}" +
                    $", Best before: {item.Groups["expireDate"].Value}, Nutrition: {item.Groups["calories"].Value}");
            }
        }
    }
}
