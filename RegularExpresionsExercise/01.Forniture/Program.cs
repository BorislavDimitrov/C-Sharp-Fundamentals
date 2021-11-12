using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Forniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Regex pattern = new Regex(@">>(?<name>[A-z]+)<<(?<price>[0-9]+\.?[0-9]+)!(?<quanity>[0-9]+)");
            List<string> fornitures = new List<string>();
            double totalSum = 0;

            while ((input = Console.ReadLine()) != "Purchase")
            {
                

                if (pattern.IsMatch(input))
                {
                    var currentForniture = pattern.Match(input);
                    totalSum += double.Parse(currentForniture.Groups["price"].Value) * double.Parse(currentForniture.Groups["quanity"].Value);
                    fornitures.Add(currentForniture.Groups["name"].Value);

                }
            }
            Console.WriteLine("Bought furniture:");
            for (int i = 0; i < fornitures.Count; i++)
            {
                Console.WriteLine(fornitures[i]);
            }
            Console.WriteLine($"Total money spend: {totalSum:F2}");
        }
    }
}
