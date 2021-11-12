using System;
using System.Text.RegularExpressions;

namespace _03.SoftuniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            Regex namePattern = new Regex(@"%(?<name>[A-Z][a-z]+)%");
            Regex productPattern = new Regex(@"<(?<product>\w+)>");
            Regex quanityPattern = new Regex(@"\|(?<quanity>[0-9]+)\|");
            Regex pricePattern = new Regex(@"(?<price>[0-9]+\.?[0-9]*)\$");
           
            double sum = 0;


            while ((input = Console.ReadLine()) != "end of shift")
            {
                if (namePattern.IsMatch(input) && productPattern.IsMatch(input) && quanityPattern.IsMatch(input) && pricePattern.IsMatch(input) )
                {
                    var name = namePattern.Match(input);
                    var product = productPattern.Match(input);
                    var quanity = int.Parse(quanityPattern.Match(input).Groups["quanity"].Value);
                    var price = double.Parse(pricePattern.Match(input).Groups["price"].Value);

                    Console.WriteLine($"{name.Groups["name"].Value}: {product.Groups["product"].Value} - {(quanity * price):F2}");
                    sum += price * quanity;
                }

            }
            Console.WriteLine($"Total income: {sum:F2}");
        }
    }
}
