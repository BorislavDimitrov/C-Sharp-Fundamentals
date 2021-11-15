using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02.RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            Dictionary<char, int> uniqueSymbols = new Dictionary<char , int>();
            Regex pattern = new Regex(@"(?<text>[\D]+)(?<number>[0-9]+)");
            var matches = pattern.Matches(text);
            StringBuilder result = new StringBuilder();

            foreach (Match match in matches)
            {
                int timesRepeat = int.Parse(match.Groups["number"].Value);

                if (timesRepeat > 0)
                {
                    string tempString = match.Groups["text"].Value.ToLower();

                    for (int i = 0; i < tempString.Length; i++)
                    {
                        if (!uniqueSymbols.ContainsKey(tempString[i]))
                        {
                            uniqueSymbols.Add(tempString[i] , 1);
                        }
                    }

                    for (int j = 0; j < timesRepeat; j++)
                    {
                        result.Append(match.Groups["text"].Value.ToUpper());
                    }
                }
                
            }

            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count}");
            Console.WriteLine(result);
        }
    }
}
