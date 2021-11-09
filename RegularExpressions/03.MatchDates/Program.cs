using System;
using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Regex patern = new Regex(@"\b(?<day>[0-9]{2})(?<separator>[-|.|\/])(?<month>[A-Z][a-z]{2})\k<separator>(?<year>[0-9]{4})\b");
            var dates = patern.Matches(text);

            foreach (Match match in dates)
            {
                var day = match.Groups["day"].Value;
                var month = match.Groups["month"].Value;
                var year = match.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
